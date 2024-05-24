/*
 * file          : UcVehicleLabel.cs
 * brief         : This file contains the code of the UserControl UcVehicleLabel
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 13.05.2024
 * update Date   : 24.05.2024
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
        public event Action BlockNotice;

        User user;
        Notice notice;
        bool bookmarked = false;
        bool isAdmin;
        bool clicked = false;
        CancellationTokenSource cts;

        public UcVehicleLabel(Notice notice, User user, bool isAdmin)
        {
            InitializeComponent();
            this.notice = notice;
            this.user = user;
            this.isAdmin = isAdmin;
        }

        public Notice Notice { get { return notice; } }
        public bool Clicked { get { return clicked; } set { clicked = value; } }

        // Méthode qui permet de mettre en place les informations de l'annonce ainsi que l'image
        private void UcVehicleLabel_Load(object sender, EventArgs e)
        {
            lblTitle.Text = notice.ToString();
            lblInfo.Text = $"Kilométrage : {notice.Mileage}  Année : {notice.Year}  Prix : {notice.Price}";
            lblDescription.Text = notice.Description;
            if (user == null)
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
            if (isAdmin)
            {
                btBlockNotice.Visible = true;
                btBlockNotice.Enabled = true;
                btBlockUser.Visible = true;
                btBlockUser.Enabled = true;
                lblDescription.MaximumSize = new System.Drawing.Size(380, 70);
            }

            cts = new CancellationTokenSource();

            GetImages(cts.Token);
            foreach (Control control in this.Controls)
            {
                if (control.Name == "pbBookMark" || control.Name == btBlockNotice.Name || control.Name == btBlockUser.Name)
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

        private void btBlockNotice_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("Êtes-vous sûr de vouloir bloquer l'annonce ?", "Confirmation de blocage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                clicked = true;
                user.BlockNotice(notice);
                BlockNotice?.Invoke();
            }
        }
    }
}
