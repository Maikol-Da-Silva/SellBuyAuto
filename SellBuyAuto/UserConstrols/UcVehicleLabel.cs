﻿/*
 * file          : UcVehicleLabel.cs
 * brief         : This file contains the code of the UserControl UcVehicleLabel
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 13.05.2024
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

namespace SellBuyAuto
{
    public partial class UcVehicleLabel : UserControl
    {
        User user;
        Notice notice;
        bool bookmarked = false;
        CancellationTokenSource cts;

        public UcVehicleLabel(Notice notice, User user)
        {
            InitializeComponent();
            this.notice = notice;
            this.user = user;
        }

        public Notice Notice { get { return notice; } }

        // Méthode qui permet de mettre en place les informations de l'annonce ainsi que l'image
        private void UcVehicleLabel_Load(object sender, EventArgs e)
        {
            lblTitle.Text = notice.ToString();
            lblInfo.Text = $"Kilométrage : {notice.Mileage}  Année : {notice.Year}  Prix : {notice.Price}";
            lblDescription.Text = notice.Description;
            if(user == null)
            {
                pbBookMark.Visible = false;
            }
            else
            {
                if (user.isNoticeBookmarked(notice.IdNotice))
                {
                    pbBookMark.Image = Properties.Resources.Bookmarked;
                    bookmarked = true;
                }
            }

            cts = new CancellationTokenSource();

            GetImages(cts.Token);
            foreach (Control control in this.Controls)
            {
                if(control.Name == "pbBookMark")
                {
                    continue;
                }
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

        private void pbBookmark_Click(object sender, EventArgs e)
        {
            if (bookmarked)
            {
                user.DeleteBookmark(notice.IdNotice);
                pbBookMark.Image = Properties.Resources.ToBookmark;
                bookmarked = false;
            }
            else
            {
                user.AddBookmark(notice);
                pbBookMark.Image = Properties.Resources.Bookmarked;
                bookmarked = true;
            }
        }
    }
}
