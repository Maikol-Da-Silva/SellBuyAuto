/*
 * file          : FormMain.cs
 * brief         : This file contains the code of the controls in the FormMain
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 13.05.2024
*/

namespace SellBuyAuto
{
    public partial class FormMain : Form
    {
        User user;
        UserControl currentUc;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DisplayHome();

        }

        // M�thode qui affiche la page d'accueil
        private void DisplayHome()
        {
            if (currentUc is UcHome)
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcHome ucHome = new UcHome();
            this.Controls.Add(ucHome);
            ucHome.Location = new Point(0, 53);
            ucHome.Name = "ucHome";
            ucHome.BringToFront();
            ucHome.AdvancedSearchClick += DisplayAdvancedSearch;
            ucHome.SearchClick += DisplayQuickSearchResult;
            currentUc = ucHome;
        }

        // M�thode qui affiche la page contenant les r�sultats de la recherche rapide
        private void DisplayQuickSearchResult()
        {
            if (currentUc != null)
            {
                UcHome ucHome = (UcHome)currentUc;

                this.Controls.Remove(currentUc);
                UcVehicleSearch ucVehicleSearch = new UcVehicleSearch(ucHome.Notices);
                this.Controls.Add(ucVehicleSearch);
                ucVehicleSearch.Location = new Point(0, 53);
                ucVehicleSearch.Name = "ucVehicleSearch";
                ucVehicleSearch.BringToFront();
                currentUc = ucVehicleSearch;
            }
        }

        // M�thode qui affiche la page de recherche avanc�e
        private void DisplayAdvancedSearch()
        {
            if (currentUc is UCAdvancedSearch)
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UCAdvancedSearch ucAdvancedSearch = new UCAdvancedSearch();
            this.Controls.Add(ucAdvancedSearch);
            ucAdvancedSearch.Location = new Point(0, 53);
            ucAdvancedSearch.Name = "ucAdvancedSearch";
            ucAdvancedSearch.BringToFront();
            ucAdvancedSearch.SearchClick += DisplayAdvancedSearchResult;
            currentUc = ucAdvancedSearch;
        }

        // M�thode qui affiche la page contenant les r�sultats de la recherche avanc�e
        private void DisplayAdvancedSearchResult()
        {
            if (currentUc != null)
            {
                UCAdvancedSearch ucAdvancedSearch = (UCAdvancedSearch)currentUc;

                this.Controls.Remove(currentUc);
                UcVehicleSearch ucVehicleSearch = new UcVehicleSearch(ucAdvancedSearch.Notices);
                this.Controls.Add(ucVehicleSearch);
                ucVehicleSearch.Location = new Point(0, 53);
                ucVehicleSearch.Name = "ucVehicleSearch";
                ucVehicleSearch.BringToFront();
                currentUc = ucVehicleSearch;
            }
        }

        private void rechercherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayAdvancedSearch();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAdvancedSearch();
        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayHome();
        }

        private void accueilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayHome();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (btLogin.Text == "Se connecter")
            {
                FormLogin frmLogin = new FormLogin();
                frmLogin.ShowDialog();
                if (frmLogin.User != null)
                {
                    user = frmLogin.User;
                    lblUsername.Text = user.Username;
                    btLogin.Text = "Se d�connecter";
                    menuStripWithoutLogin.Enabled = false;
                    menuStripWithoutLogin.Visible = false;
                    menuStripWithLogin.Enabled = true;
                    menuStripWithLogin.Visible = true;
                }
            }
            else
            {
                user = null;
                lblUsername.Text = "";
                btLogin.Text = "Se connecter";
                menuStripWithoutLogin.Enabled = true;
                menuStripWithoutLogin.Visible = true;
                menuStripWithLogin.Enabled = false;
                menuStripWithLogin.Visible = false;
            }
        }
    }
}
