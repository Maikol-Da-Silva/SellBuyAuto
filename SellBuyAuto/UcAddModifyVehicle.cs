/*
 * file          : UcAddModifyVehicle.cs
 * brief         : This file contains the code of the UserControl UcAddModifyVehicle
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 13.05.2024
 * update Date   : 14.05.2024
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SellBuyAuto
{
    public partial class UcAddModifyVehicle : UserControl
    {
        public event Action DisplayHome;

        User user;
        string[] imagesNames;

        public UcAddModifyVehicle(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        // Permet de charger les motorisations dans le ComboBox
        private void UcAddModifyVehicle_Load(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            List<string> engineTypes = db.GetEngineTypes();
            foreach (var engineType in engineTypes)
            {
                cbEngineType.Items.Add(engineType);
            }
        }

        // Permet de récupérer les images dans l'ordinateur. Seul les jpg, jpeg et les png sont acceptés
        private void btImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "Images|*.jpg;*.jpeg;*.png" })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.FileNames.Length > 5)
                    {
                        MessageBox.Show("Un maximum de 5 images est autorisé !");
                    }
                    else
                    {
                        imagesNames = openFile.FileNames;
                        lblNbImages.Text = $"{openFile.FileNames.Length} sur 5";
                    }
                }
            }
        }

        // Check si tout les champs sont correct et insère toutes les données dans la base de donnée ainsi que les images dans le serveur FTP
        private void btValidate_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Length > 300)
            {
                MessageBox.Show("La description ne peut pas dépasser 300 caractères !");
                return;
            }
            if (txtBrand.Text.Length > 45)
            {
                MessageBox.Show("Le nom de la marque ne peut pas dépasser 45 caractères !");
                return;
            }
            if (txtModel.Text.Length > 45)
            {
                MessageBox.Show("Le nom du modèle ne peut pas dépasser 45 caractères !");
                return;
            }
            if (txtBrand.Text != "" && txtModel.Text != "" && txtDescription.Text != "" && cbEngineType.SelectedIndex != -1 && imagesNames != null)
            {
                DBConnection db = new DBConnection();
                int idBrand;
                int idModel;
                int idCar;
                try
                {
                    idBrand = db.GetId("Brands", txtBrand.Text);
                }
                catch (Exception ex)
                {
                    db.CloseConnection();
                    idBrand = db.AddBrand(txtBrand.Text);
                }
                try
                {
                    idModel = db.GetId("Models", txtModel.Text);
                }
                catch (Exception ex)
                {
                    db.CloseConnection();
                    idModel = db.AddModel(txtModel.Text, idBrand);
                }
                idCar = db.AddCar((int)numYear.Value, (int)numMileage.Value, txtDescription.Text, idModel, (cbEngineType.SelectedIndex + 1));
                db.AddNotice(DateTime.Now.ToString("yyyy-MM-dd"), (int)numPrice.Value, user.IdUser, idCar);
                UploadImages(idCar);
                string images = "";
                for (int i = 1; i <= imagesNames.Length; i++)
                {
                    string[] strings = imagesNames[i - 1].Split(".");
                    string newImageName = $"{idCar}_{i}.{strings[strings.Length - 1]}";
                    images += newImageName + "/";
                }
                images = images.Remove(images.Length - 1);
                db.UpdateImages(images, idCar);

                MessageBox.Show("La voiture a bien été ajouté");

                DisplayHome?.Invoke();

            }
            else
            {
                MessageBox.Show("Un des champs n'est pas correctement rempli !");
            }

        }

        // Permet de upload les images en arrière-plan
        async void UploadImages(int idCar)
        {
            FTPConnection ftp = new FTPConnection();
            await Task.Run(() =>
            {
                for (int i = 1; i <= imagesNames.Length; i++)
                {
                    string[] strings = imagesNames[i-1].Split(".");
                    string newImageName = $"{idCar}_{i}.{strings[strings.Length - 1]}";
                    ftp.UploadImage(imagesNames[i-1], newImageName);
                }
            });
        }
    }
}
