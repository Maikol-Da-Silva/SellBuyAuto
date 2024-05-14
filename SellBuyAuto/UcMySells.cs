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
        List<Notice> notices;
        int currentPage = 1;
        int maxPages;
        int maxNoticePerPage = 10;

        public UcMySells(List<Notice> notices)
        {
            InitializeComponent();
            this.notices = notices;
            double max = (double)notices.Count() / maxNoticePerPage;
            maxPages = (int)Math.Ceiling(max);
        }

        private void UcMySells_Load(object sender, EventArgs e)
        {
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
                    UcVehicleLabel ucVehicleLabel = new UcVehicleLabel(notices[currentNotice]);
                    FlpVehicles.Controls.Add(ucVehicleLabel);
                    ucVehicleLabel.BorderStyle = BorderStyle.FixedSingle;
                    ucVehicleLabel.Name = "ucVehicleLabel";
                    ucVehicleLabel.BringToFront();
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
                    }
                }
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
                    }
                }
                currentPage++;
                DisplayPage();
            }
        }
    }
}
