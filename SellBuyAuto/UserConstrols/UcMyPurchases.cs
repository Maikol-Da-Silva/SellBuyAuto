/*
 * file          : UcMyPurchases.cs
 * brief         : This file contains the code of the UserControl UcMyPurchases
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 21.05.2024
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

namespace SellBuyAuto.UserConstrols
{
    public partial class UcMyPurchases : UserControl
    {
        public event Action DisplayDetail;

        User user;
        List<Notice> notices;
        Notice notice;
        List<UcMyPurchasesVehicleLabel> ucMyPurchasesVehicleLabels;
        int currentPage = 1;
        int maxPages;
        int maxNoticePerPage = 10;

        public UcMyPurchases(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public Notice Notice { get { return notice; } }

        private void UcMyPurchases_Load(object sender, EventArgs e)
        {
            ucMyPurchasesVehicleLabels = new List<UcMyPurchasesVehicleLabel>();
            this.notices = user.GetPurchases();
            if (this.notices == null)
            {
                DisplayError();
                return;
            }
            double max = (double)notices.Count() / maxNoticePerPage;
            maxPages = (int)Math.Ceiling(max);
            DisplayPage();
        }

        private void DisplayPage()
        {
            FlpVehicles.Visible = false;
            FlpVehicles.Controls.Clear();
            for (int i = 0; i < maxNoticePerPage; i++)
            {
                int currentNotice = ((currentPage - 1) * maxNoticePerPage) + i;
                if (currentNotice <= notices.Count - 1)
                {
                    UcMyPurchasesVehicleLabel ucMyPurchasesVehicleLabel = new UcMyPurchasesVehicleLabel(notices[currentNotice]);
                    FlpVehicles.Controls.Add(ucMyPurchasesVehicleLabel);
                    ucMyPurchasesVehicleLabel.BorderStyle = BorderStyle.FixedSingle;
                    ucMyPurchasesVehicleLabel.Name = "ucMyPurchasesVehicleLabel";
                    ucMyPurchasesVehicleLabel.BringToFront();
                    ucMyPurchasesVehicleLabel.Click += ucMyPurchasesVehicleLabel_Click;
                    ucMyPurchasesVehicleLabels.Add(ucMyPurchasesVehicleLabel);
                }
            }
            lblPages.Text = $"Page {currentPage} sur {maxPages}";
            FlpVehicles.Visible = true;
        }

        private void DisplayError()
        {
            MessageBox.Show("Vous n'avez aucun achat !");
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                for (int i = 0; i < maxNoticePerPage; i++)
                {
                    int currentNotice = ((currentPage - 1) * maxNoticePerPage) + i;
                    if (currentNotice <= notices.Count - 1)
                    {
                        notices[currentNotice].ClearImages();
                        ucMyPurchasesVehicleLabels[i].CancelGetImages();
                    }
                }
                ucMyPurchasesVehicleLabels.Clear();
                currentPage--;
                DisplayPage();
            }
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPages)
            {
                for (int i = 0; i < maxNoticePerPage; i++)
                {
                    int currentNotice = ((currentPage - 1) * maxNoticePerPage) + i;
                    if (currentNotice <= notices.Count - 1)
                    {
                        notices[currentNotice].ClearImages();
                        ucMyPurchasesVehicleLabels[i].CancelGetImages();
                    }
                }
                ucMyPurchasesVehicleLabels.Clear();
                currentPage++;
                DisplayPage();
            }
        }

        private void ucMyPurchasesVehicleLabel_Click(object sender, EventArgs e)
        {
            if (sender is UcMyPurchasesVehicleLabel)
            {
                UcMyPurchasesVehicleLabel ucMyPurchasesVehicleLabel = (UcMyPurchasesVehicleLabel)sender;
                this.notice = ucMyPurchasesVehicleLabel.Notice;
                DisplayDetail?.Invoke();
            }
        }
    }
}
