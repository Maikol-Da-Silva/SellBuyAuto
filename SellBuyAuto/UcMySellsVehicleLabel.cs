﻿/*
 * file          : UcMySellsVehicleLabel.cs
 * brief         : This file contains the code of the UserControl UcMySellsVehicleLabel
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 14.05.2024
 * update Date   : 16.05.2024
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
        public event Action ModifyClick;
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
        public bool Clicked { get { return clicked; }}

        // Méthode qui permet de mettre en place les informations de l'annonce ainsi que l'image
        private void UcMySellsVehicleLabel_Load(object sender, EventArgs e)
        {
            lblTitle.Text = notice.ToString();
            lblInfo.Text = $"Kilométrage : {notice.Mileage}  Année : {notice.Year}  Prix : {notice.Price}";
            lblDescription.Text = notice.Description;
            cts = new CancellationTokenSource();
            GetImages(cts.Token);
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

        private void btModify_Click(object sender, EventArgs e)
        {
            clicked = true;
            ModifyClick?.Invoke();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            clicked = true;
            DeleteClick?.Invoke();
        }
    }
}
