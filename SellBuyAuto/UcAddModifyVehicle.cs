/*
 * file          : UcAddModifyVehicle.cs
 * brief         : This file contains the code of the UserControl UcAddModifyVehicle
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 13.05.2024
 * update Date   : 15.05.2024
*/

using Org.BouncyCastle.Crypto;
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
        public event Action DisplaySells;

        User user;
        Notice notice;
        string[] imagesNames;

        public UcAddModifyVehicle(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public UcAddModifyVehicle(User user, Notice notice)
        {
            InitializeComponent();
            this.user = user;
            this.notice = notice;
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
            if (notice == null)
            {
                
                lblAddModify.Text = "Ajouter";
                btValidate.Text = "Mettre en vente";
            }
            else
            {
                txtBrand.Text = notice.Brand;
                txtModel.Text = notice.Model;
                txtDescription.Text = notice.Description;
                numMileage.Value = notice.Mileage;
                numPrice.Value = notice.Price;
                numYear.Value = notice.Year;

                cbEngineType.SelectedItem = notice.EngineType;

                lblNbImages.Text = $"{notice.GetImages().Count} sur 5";
                lblAddModify.Text = "Modifier";
                btValidate.Text = "Valider";
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
            if (txtDescription.Text.Length > 600)
            {
                MessageBox.Show("La description ne peut pas dépasser 600 caractères !");
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
            if (txtBrand.Text != "" && txtModel.Text != "" && txtDescription.Text != "" && cbEngineType.SelectedIndex != -1 && btValidate.Text == "Valider")
            {
                user.ModifyNotice(notice.IdNotice, txtBrand.Text, txtModel.Text, txtDescription.Text, (cbEngineType.SelectedIndex + 1), cbEngineType.Text, (int)numPrice.Value, (int)numYear.Value, (int)numMileage.Value, imagesNames);
                
                MessageBox.Show("La voiture a bien été modifié");

                DisplaySells?.Invoke();

            }
            else if (txtBrand.Text != "" && txtModel.Text != "" && txtDescription.Text != "" && cbEngineType.SelectedIndex != -1 && imagesNames != null && btValidate.Text == "Mettre en vente")
            {
                user.AddNotice(txtBrand.Text, txtModel.Text, txtDescription.Text, (cbEngineType.SelectedIndex + 1), cbEngineType.Text, (int)numPrice.Value, (int)numYear.Value, (int)numMileage.Value, imagesNames);

                MessageBox.Show("La voiture a bien été ajouté");

                DisplaySells?.Invoke();

            }
            else
            {
                MessageBox.Show("Un des champs n'est pas correctement rempli !");
            }

        }
    }
}
