/*
 * file          : UcMySellsVehicleLabel.cs
 * brief         : This file contains the code of the UserControl UcMySellsVehicleLabel
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 14.05.2024
 * update Date   : 17.05.2024
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

namespace SellBuyAuto
{
    public partial class UcMySellsVehicleLabel : UserControl
    {
        public event Action SoldClick;
        public event Action DeleteClick;

        Notice notice;
        CancellationTokenSource cts;
        bool clicked = false;

        public UcMySellsVehicleLabel(Notice notice)
        {
            InitializeComponent();
            this.notice = notice;
        }

        public Notice Notice { get { return notice; } }
        public bool Clicked { get { return clicked; } set { clicked = value; } }

        // Méthode qui permet de mettre en place les informations de l'annonce ainsi que l'image
        private void UcMySellsVehicleLabel_Load(object sender, EventArgs e)
        {
            lblTitle.Text = notice.ToString();
            lblInfo.Text = $"Kilométrage : {notice.Mileage}  Année : {notice.Year}  Prix : {notice.Price}";
            lblDescription.Text = notice.Description;
            cts = new CancellationTokenSource();
            GetImages(cts.Token);

            if(notice.IdBuyer != 0)
            {
                SetSold();
            }
            else
            {
                foreach (Control control in this.Controls)
                {
                    if (control.Name == btSold.Name)
                    {
                        continue;
                    }
                    control.Click += CLickControl;
                }
            }
        }

        public void SetSold()
        {
            lblSold.Visible = true;
            this.BackColor = Color.Gray;
            btSold.Visible = false;
            foreach (Control control in this.Controls)
            {
                if (control.Name == btDelete.Name || control.Name == lblSold.Name)
                {
                    continue;
                }
                control.Enabled = false;
            }
        }

        private void CLickControl(object sender, EventArgs e)
        {

            this.OnClick(e);
        }

        public void CancelGetImages()
        {
            cts.Cancel();
        }

        // Méthode qui permet de récupérer les images en arrière-plan
        async void GetImages(CancellationToken token)
        {
            await Task.Run(() =>
            {
                List<Bitmap> images = notice.GetImagesFromFTP(token);
                if (images.Count > 0)
                {
                    pbVehicleImage.Image = images[0];
                }
            });
        }

        private void btSold_Click(object sender, EventArgs e)
        {
            clicked = true;
            SoldClick?.Invoke();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            clicked = true;
            DeleteClick?.Invoke();
        }
    }
}
