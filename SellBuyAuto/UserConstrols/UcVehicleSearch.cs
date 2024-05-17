/*
 * file          : UcVehicleSearch.cs
 * brief         : This file contains the code of the UserControl UcVehicleSearch
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 08.05.2024
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
    public partial class UcVehicleSearch : UserControl
    {
        public event Action DisplayDetail;

        List<Notice> notices;
        List<UcVehicleLabel> ucVehicleLabels;
        Notice notice;
        int currentPage = 1;
        int maxPages;
        int maxNoticePerPage = 10;

        // Constructeur qui prend comme paramètre la liste des annonces
        public UcVehicleSearch(List<Notice> notices)
        {
            InitializeComponent();
            this.notices = notices;
            double max = (double)notices.Count() / maxNoticePerPage;
            maxPages = (int)Math.Ceiling(max);
        }

        public Notice Notice {  get { return notice; } }

        private void UcVehicleSearch_Load(object sender, EventArgs e)
        {
            ucVehicleLabels = new List<UcVehicleLabel>();
            DisplayPage();
        }

        // Méthode qui permet d'affiché les annonces peu à peu afin de ne pas avoir de temps de téléchargement trop long
        private void DisplayPage()
        {
            FlpVehicles.Visible = false;
            FlpVehicles.Controls.Clear();
            for (int i = 0; i < maxNoticePerPage; i++)
            {
                int currentNotice = ((currentPage - 1) * maxNoticePerPage) + i;
                if (currentNotice <= notices.Count - 1)
                {
                    UcVehicleLabel ucVehicleLabel = new UcVehicleLabel(notices[currentNotice]);
                    FlpVehicles.Controls.Add(ucVehicleLabel);
                    ucVehicleLabel.BorderStyle = BorderStyle.FixedSingle;
                    ucVehicleLabel.Name = "ucVehicleLabel";
                    ucVehicleLabel.BringToFront();
                    ucVehicleLabel.Click += ucVehicleLabel_Click;
                    ucVehicleLabels.Add(ucVehicleLabel);
                }
            }
            lblPages.Text = $"Page {currentPage} sur {maxPages}";
            FlpVehicles.Visible = true;
        }

        // Méthode qui permet de passer à la page précédente
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
                        ucVehicleLabels[i].CancelGetImages();
                    }
                }
                ucVehicleLabels.Clear();
                currentPage--;
                DisplayPage();
            }
        }

        // Méthode qui permet de passer à la page suivante
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
                        ucVehicleLabels[i].CancelGetImages();
                    }
                }
                ucVehicleLabels.Clear();
                currentPage++;
                DisplayPage();
            }
        }

        private void ucVehicleLabel_Click(object sender, EventArgs e)
        {
            if(sender is UcVehicleLabel)
            {
                UcVehicleLabel ucVehicleLabel = (UcVehicleLabel)sender;
                this.notice = ucVehicleLabel.Notice;
                DisplayDetail?.Invoke();
            }
        }
    }
}
