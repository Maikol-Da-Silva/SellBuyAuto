/*
 * file          : UcVehicleSearch.cs
 * brief         : This file contains the code of the UserControl UcVehicleSearch
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 08.05.2024
 * update Date   : 24.05.2024
*/

using MySql.Data.MySqlClient;
using SellBuyAuto.UserConstrols;
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

        User user;
        List<Notice> notices;
        List<UcVehicleLabel> ucVehicleLabels;
        Notice notice;
        bool isAdmin;
        int currentPage;
        int maxPages;
        int maxNoticePerPage = 10;

        // Constructeur qui prend comme paramètre la liste des annonces
        public UcVehicleSearch(List<Notice> notices, User user, int currentPage, bool isAdmin = false)
        {
            InitializeComponent();
            this.notices = notices;
            this.isAdmin = isAdmin;
            double max = (double)notices.Count() / maxNoticePerPage;
            maxPages = (int)Math.Ceiling(max);
            this.user = user;
            this.currentPage = currentPage;
        }

        public Notice Notice {  get { return notice; } }
        public List<Notice> Notices {  get { return notices; } }
        public int CurrentPage {  get { return currentPage; } }

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
                    UcVehicleLabel ucVehicleLabel = new UcVehicleLabel(notices[currentNotice], user, isAdmin);
                    FlpVehicles.Controls.Add(ucVehicleLabel);
                    ucVehicleLabel.BorderStyle = BorderStyle.FixedSingle;
                    ucVehicleLabel.Name = "ucVehicleLabel";
                    ucVehicleLabel.BringToFront();
                    ucVehicleLabel.Click += ucVehicleLabel_Click;
                    ucVehicleLabel.BlockNotice += BlockNotice;
                    ucVehicleLabels.Add(ucVehicleLabel);
                }
            }
            lblPages.Text = $"Page {currentPage} sur {maxPages}";
            FlpVehicles.Visible = true;
        }

        //Méthode qui permet de supprimer l'étiquette du flowlayoutpanel
        private void BlockNotice()
        {
            foreach (Control control in FlpVehicles.Controls)
            {
                UcVehicleLabel ucVehicleLabel = (UcVehicleLabel)control;
                if (ucVehicleLabel.Clicked)
                {
                    notices.Remove(ucVehicleLabel.Notice);
                    FlpVehicles.Controls.Remove(ucVehicleLabel);
                    MessageBox.Show("L'annonce a bien été bloquée");
                    break;
                }
            }
        }

        public void BlockNoticeFromDetail(Notice notice)
        {
            foreach (Control control in FlpVehicles.Controls)
            {
                UcVehicleLabel ucVehicleLabel = (UcVehicleLabel)control;
                if (ucVehicleLabel.Notice == notice)
                {
                    notices.Remove(ucVehicleLabel.Notice);
                    FlpVehicles.Controls.Remove(ucVehicleLabel);
                    MessageBox.Show("L'annonce a bien été bloquée");
                    break;
                }
            }
        }

        // Méthode qui permet de passer à la page précédente
        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                MySqlConnection.ClearAllPools();
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
                MySqlConnection.ClearAllPools();
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
