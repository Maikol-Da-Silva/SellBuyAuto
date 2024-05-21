/*
 * file          : UcMyBookmarks.cs
 * brief         : This file contains the code of the UserControl UcMyBookmarks
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

namespace SellBuyAuto
{
    public partial class UcMyBookmarks : UserControl
    {
        public event Action DisplayDetail;

        User user;
        List<Notice> notices;
        Notice currentNotice;
        Notice notice;
        List<UcMyBookmarksVehicleLabel> ucMyBookmarksVehicleLabels;
        int currentPage = 1;
        int maxPages;
        int maxNoticePerPage = 10;

        public UcMyBookmarks(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public Notice Notice { get { return notice; } }

        private void UcMyBookmarks_Load(object sender, EventArgs e)
        {
            ucMyBookmarksVehicleLabels = new List<UcMyBookmarksVehicleLabel>();
            this.notices = user.GetBookmarks();
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
                    UcMyBookmarksVehicleLabel ucMyBookmarksVehicleLabel = new UcMyBookmarksVehicleLabel(notices[currentNotice]);
                    FlpVehicles.Controls.Add(ucMyBookmarksVehicleLabel);
                    ucMyBookmarksVehicleLabel.BorderStyle = BorderStyle.FixedSingle;
                    ucMyBookmarksVehicleLabel.Name = "ucMyBookmarlsVehicleLabel";
                    ucMyBookmarksVehicleLabel.BringToFront();
                    ucMyBookmarksVehicleLabel.DeleteClick += DeleteBookmark;
                    ucMyBookmarksVehicleLabel.Click += ucMyBookmarksVehicleLabel_Click;
                    ucMyBookmarksVehicleLabels.Add(ucMyBookmarksVehicleLabel);
                }
            }
            lblPages.Text = $"Page {currentPage} sur {maxPages}";
            FlpVehicles.Visible = true;
        }

        private void DisplayError()
        {
            MessageBox.Show("Vous n'avez aucun favoris !");
        }

        private void DeleteBookmark()
        {
            int noticeId = 0;
            UcMyBookmarksVehicleLabel? ucMyBookmarksVehicleLabel = null;
            foreach (Control control in FlpVehicles.Controls)
            {
                ucMyBookmarksVehicleLabel = (UcMyBookmarksVehicleLabel)control;
                if (ucMyBookmarksVehicleLabel.Clicked)
                {
                    Notice notice = ucMyBookmarksVehicleLabel.Notice;
                    noticeId = notice.IdNotice;
                    break;
                }
            }
            FlpVehicles.Controls.Remove(ucMyBookmarksVehicleLabel);
            user.DeleteBookmark(noticeId);
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
                        ucMyBookmarksVehicleLabels[i].CancelGetImages();
                    }
                }
                ucMyBookmarksVehicleLabels.Clear();
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
                        ucMyBookmarksVehicleLabels[i].CancelGetImages();
                    }
                }
                ucMyBookmarksVehicleLabels.Clear();
                currentPage++;
                DisplayPage();
            }
        }

        private void ucMyBookmarksVehicleLabel_Click(object sender, EventArgs e)
        {
            if (sender is UcMyBookmarksVehicleLabel)
            {
                UcMyBookmarksVehicleLabel ucMyBookmarksVehicleLabel = (UcMyBookmarksVehicleLabel)sender;
                this.notice = ucMyBookmarksVehicleLabel.Notice;
                DisplayDetail?.Invoke();
            }
        }
    }
}
