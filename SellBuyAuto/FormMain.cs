/*
 * file          : FormHome.cs
 * brief         : This file contains the code of the controls in the FormHome
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 07.05.2024
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
            currentUc = ucHome;
        }

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
            currentUc = ucAdvancedSearch;
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
            }
        }
    }
}
