/*
 * file          : UcVehicleDetail.cs
 * brief         : This file contains the code of the UserControl UcVehicleDetail
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 17.05.2024
 * update Date   : 21.05.2024
*/

using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UcVehicleDetail : UserControl
    {
        public event Action GoBack;
        public event Action BuyClick;
        public event Action BlockNotice;

        Notice notice;
        int currentImage = 0;
        int nbImages;
        bool showBuy;
        bool isAdmin;

        public UcVehicleDetail(Notice notice, bool isAdmin, bool showBuy = true)
        {
            InitializeComponent();
            this.notice = notice;
            this.isAdmin = isAdmin;
            this.showBuy = showBuy;
        }

        public Notice Notice { get { return notice; } }

        private void UcVehicleDetail_Load(object sender, EventArgs e)
        {
            pbImage.Image = notice.GetImages()[currentImage];
            lblBrandModel.Text = notice.ToString();
            lblPrice.Text = $"Prix : {notice.Price} CHF";
            lblYear.Text = $"Année : {notice.Year}";
            lblMileage.Text = $"Kilométrage : {notice.Mileage} km";
            lblEngineType.Text = $"Motorisation : {notice.EngineType}";
            lblDescription.Text = notice.Description;

            nbImages = notice.GetImages().Count;

            if (!showBuy)
            {
                btBuy.Enabled = false;
                btBuy.Visible = false;
            }

            if (isAdmin)
            {
                btBlockNotice.Visible = true;
                btBlockNotice.Enabled = true;
                btBlockUser.Visible = true;
                btBlockUser.Enabled = true;
            }

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke();
        }

        private void btImageNext_Click(object sender, EventArgs e)
        {
            if (currentImage >= nbImages - 1)
            {
                currentImage = 0;
            }
            else
            {
                currentImage++;
            }
            pbImage.Image = notice.GetImages()[currentImage];
        }

        private void btImagePrevious_Click(object sender, EventArgs e)
        {
            if (currentImage <= 0)
            {
                currentImage = nbImages - 1;
            }
            else
            {
                currentImage--;
            }
            pbImage.Image = notice.GetImages()[currentImage];
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            BuyClick?.Invoke();
        }

        private void btBlockNotice_Click(object sender, EventArgs e)
        {
            DialogResult myResult = MessageBox.Show("Êtes-vous sûr de vouloir bloquer l'annonce ?", "Confirmation de blocage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                BlockNotice?.Invoke();
            }
        }
    }
}
