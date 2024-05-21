/*
 * file          : UcMySells.cs
 * brief         : This file contains the code of the UserControl UcMySells
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 14.05.2024
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
    public partial class UcMySells : UserControl
    {
        public event Action ModifyClick;

        User user;
        List<Notice> notices;
        Notice currentNotice;
        List<UcMySellsVehicleLabel> ucMySellsVehicleLabels;
        UcVehicleSold ucVehicleSold;
        int currentPage = 1;
        int maxPages;
        int maxNoticePerPage = 10;

        public UcMySells(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public Notice NoticeToModify { get { return currentNotice; } }

        private void UcMySells_Load(object sender, EventArgs e)
        {
            ucMySellsVehicleLabels = new List<UcMySellsVehicleLabel>();
            this.notices = user.GetSells();
            if(this.notices == null )
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
                    UcMySellsVehicleLabel ucMySellsVehicleLabel = new UcMySellsVehicleLabel(notices[currentNotice]);
                    FlpVehicles.Controls.Add(ucMySellsVehicleLabel);
                    ucMySellsVehicleLabel.BorderStyle = BorderStyle.FixedSingle;
                    ucMySellsVehicleLabel.Name = "ucMySellsVehicleLabel";
                    ucMySellsVehicleLabel.BringToFront();
                    ucMySellsVehicleLabel.SoldClick += DisplaySoldPage;
                    ucMySellsVehicleLabel.DeleteClick += DeleteNotice;
                    if (notices[currentNotice].IdBuyer == 0)
                    {
                        ucMySellsVehicleLabel.Click += UcMySellsVehicleLabel_Click;
                    }
                    ucMySellsVehicleLabels.Add(ucMySellsVehicleLabel);
                }
            }
            lblPages.Text = $"Page {currentPage} sur {maxPages}";
            FlpVehicles.Visible = true;
        }

        // Méthode qui permet d'afficher la page pour marque l'annonce comme vendue
        private void DisplaySoldPage()
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = false;
            }
            foreach (Control control in FlpVehicles.Controls)
            {
                UcMySellsVehicleLabel ucMySellsVehicleLabel = (UcMySellsVehicleLabel)control;
                if (ucMySellsVehicleLabel.Clicked)
                {
                    currentNotice = ucMySellsVehicleLabel.Notice;
                    break;
                }
            }
            ucVehicleSold = new UcVehicleSold(user, currentNotice.IdNotice);
            this.Controls.Add(ucVehicleSold);
            ucVehicleSold.Location = new Point(387, 183);
            ucVehicleSold.Name = "ucVehicleSold";
            ucVehicleSold.BorderStyle = BorderStyle.FixedSingle;
            ucVehicleSold.Cancel += CancelSoldPage;
            ucVehicleSold.Validate += ValidateSoldPage;
            ucVehicleSold.BringToFront();
        }

        private void ValidateSoldPage()
        {
            CancelSoldPage();
            foreach (Control control in FlpVehicles.Controls)
            {
                UcMySellsVehicleLabel ucMySellsVehicleLabel = (UcMySellsVehicleLabel)control;
                if (ucMySellsVehicleLabel.Clicked)
                {
                    ucMySellsVehicleLabel.Clicked = false;
                    ucMySellsVehicleLabel.SetSold();
                    user.SetSold(currentNotice.IdNotice, ucVehicleSold.Buyer);
                    ucVehicleSold = null;
                    break;
                }
            }
        }

        private void CancelSoldPage()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Enabled)
                {
                    this.Controls.Remove(control);
                }
                else
                {
                    control.Enabled = true;
                }
            }
        }

        // Méthode qui permet de supprimer une annonce (rend le champs active a false dans la base de donnée)
        private void DeleteNotice()
        {
            int noticeId = 0;
            bool delete = false;
            UcMySellsVehicleLabel? ucMySellsVehicleLabel = null;
            foreach (Control control in FlpVehicles.Controls)
            {
                ucMySellsVehicleLabel = (UcMySellsVehicleLabel)control;
                if (ucMySellsVehicleLabel.Clicked)
                {
                    Notice notice = ucMySellsVehicleLabel.Notice;
                    noticeId = notice.IdNotice;
                    break;
                }
            }
            if (noticeId != 0)
            {

                DBConnection db = new DBConnection();
                try
                {
                    List<int> users = db.GetUsersBookMark(noticeId);
                    if (users.Count > 0)
                    {
                        DialogResult myResult = MessageBox.Show("Un utilisateur a mis votre annonce en favoris. Êtes-vous sûr de vouloir supprimé l'annonce ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (myResult == DialogResult.Yes)
                        {
                            delete = true;
                            foreach (int userId in users)
                            {
                                db.DeleteBookmark(noticeId, userId);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    db.CloseConnection();
                    DialogResult myResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimé l'annonce ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (myResult == DialogResult.Yes)
                    {
                        delete = true;
                    }
                }
                finally
                {
                    if(delete)
                    {
                        db.DeleteNotices(noticeId);
                        FlpVehicles.Controls.Remove(ucMySellsVehicleLabel);
                        user.DeleteNotice(noticeId);
                    }
                }
            }
        }

        private void DisplayError()
        {
            MessageBox.Show("Vous n'avez aucune vente !");
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
                        ucMySellsVehicleLabels[i].CancelGetImages();
                    }
                }
                ucMySellsVehicleLabels.Clear();
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
                        ucMySellsVehicleLabels[i].CancelGetImages();
                    }
                }
                ucMySellsVehicleLabels.Clear();
                currentPage++;
                DisplayPage();
            }
        }

        // Méthode qui permet d'affiché la page de modification à travers un event envoyé au FormMain
        private void UcMySellsVehicleLabel_Click(object sender, EventArgs e)
        {
            if (sender is UcMySellsVehicleLabel)
            {
                foreach (Control control in FlpVehicles.Controls)
                {
                    UcMySellsVehicleLabel VehicleLabel = (UcMySellsVehicleLabel)control;

                    VehicleLabel.CancelGetImages();
                }

                ucMySellsVehicleLabels.Clear();

                UcMySellsVehicleLabel ucMySellsVehicleLabel = (UcMySellsVehicleLabel)sender;
                currentNotice = ucMySellsVehicleLabel.Notice;
                ModifyClick?.Invoke();
            }
        }
    }
}
