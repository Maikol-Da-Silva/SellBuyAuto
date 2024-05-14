/*
 * file          : FormMain.cs
 * brief         : This file contains the code of the controls in the FormMain
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 14.05.2024
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

        // Méthode qui affiche la page d'accueil
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

        // Méthode qui affiche la page contenant les résultats de la recherche rapide
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

        // Méthode qui affiche la page de recherche avancée
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

        // Méthode qui affiche la page contenant les résultats de la recherche avancée
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

        // Méthode qui affiche la page d'ajout d'une annonce
        private void DisplayAddNotice()
        {
            if (currentUc is UcAddModifyVehicle)
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcAddModifyVehicle ucAddModifyVehicle = new UcAddModifyVehicle(user);
            this.Controls.Add(ucAddModifyVehicle);
            ucAddModifyVehicle.Location = new Point(0, 53);
            ucAddModifyVehicle.Name = "ucAddModifyVehicle";
            ucAddModifyVehicle.BringToFront();
            ucAddModifyVehicle.DisplayHome += DisplayHome;
            currentUc = ucAddModifyVehicle;
        }

        //Méthode qui affiche la page mes ventes
        private void DisplayMySells()
        {
            if (currentUc is UcMySells)
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcMySells ucMySells = new UcMySells(user.GetSells());
            this.Controls.Add(ucMySells);
            ucMySells.Location = new Point(0, 53);
            ucMySells.Name = "ucMySells";
            ucMySells.BringToFront();
            ucMySells.ModifyClick += DisplayModifyNotice;
            currentUc = ucMySells;
        }

        // Méthode qui affiche la page de modification
        private void DisplayModifyNotice()
        {
            UcMySells ucMySells = (UcMySells)currentUc; ;
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcAddModifyVehicle ucAddModifyVehicle = new UcAddModifyVehicle(user, ucMySells.NoticeToModify);
            this.Controls.Add(ucAddModifyVehicle);
            ucAddModifyVehicle.Location = new Point(0, 53);
            ucAddModifyVehicle.Name = "ucAddModifyVehicle";
            ucAddModifyVehicle.BringToFront();
            ucAddModifyVehicle.DisplayHome += DisplayHome;
            currentUc = ucAddModifyVehicle;
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

        private void vendreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayAddNotice();
        }

        private void mesVentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayMySells();
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
                    btLogin.Text = "Se déconnecter";
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
                DisplayHome();
            }
        }
    }
}
