/*
 * file          : UcMyPurchasesVehicleLabel.cs
 * brief         : This file contains the code of the UserControl UcMyPurchasesVehicleLabel
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 21.05.2024
 * update Date   : 21.05.2024
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

namespace SellBuyAuto.UserConstrols
{
    public partial class UcMyPurchasesVehicleLabel : UserControl
    {
        public event Action DeleteClick;

        Notice notice;
        CancellationTokenSource cts;
        bool clicked = false;

        public UcMyPurchasesVehicleLabel(Notice notice)
        {
            InitializeComponent();
            this.notice = notice;
        }

        public Notice Notice { get { return notice; } }
        public bool Clicked { get { return clicked; } set { clicked = value; } }

        private void UcMyPurchasesVehicleLabel_Load(object sender, EventArgs e)
        {
            lblTitle.Text = notice.ToString();
            lblInfo.Text = $"Kilométrage : {notice.Mileage}  Année : {notice.Year}  Prix : {notice.Price}";
            lblDescription.Text = notice.Description;
            cts = new CancellationTokenSource();
            GetImages(cts.Token);
            foreach (Control control in this.Controls)
            {
                control.Click += CLickControl;
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
    }
}
