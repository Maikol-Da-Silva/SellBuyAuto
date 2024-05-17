/*
 * file          : FormMain.cs
 * brief         : This file contains the code of the controls in the FormMain
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 17.05.2024
*/

using Mysqlx.Crud;

namespace SellBuyAuto
{
    public partial class FormMain : Form
    {
        User user;
        UserControl currentUc;
        UcVehicleDetail ucVehicleDetail;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DisplayHome();

        }

        // Méthode qui affiche la page d'accueil
        private void DisplayHome(bool cont = false)
        {
            if (!cont)
            {
                if (currentUc is UcHome || CheckAddOrModify())
                {
                    return;
                }
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
            btLogin.BringToFront();
            lblUsername.BringToFront();
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
                ucVehicleSearch.DisplayDetail += DisplayVehicleDetail;
                currentUc = ucVehicleSearch;
                btLogin.BringToFront();
                lblUsername.BringToFront();
            }
        }

        // Méthode qui affiche la page de recherche avancée
        private void DisplayAdvancedSearch()
        {
            if (currentUc is UCAdvancedSearch || CheckAddOrModify())
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
            btLogin.BringToFront();
            lblUsername.BringToFront();
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
                ucVehicleSearch.DisplayDetail += DisplayVehicleDetail;
                currentUc = ucVehicleSearch;
                btLogin.BringToFront();
                lblUsername.BringToFront();
            }
        }

        // Méthode qui permet d'afficher le détail d'une annonce
        private void DisplayVehicleDetail()
        {
            if(currentUc != null)
            {
                currentUc.Visible = false;

                UcVehicleSearch ucVehicleSearch = (UcVehicleSearch)currentUc;

                if (ucVehicleDetail != null)
                {
                    ucVehicleDetail = null;
                }

                ucVehicleDetail = new UcVehicleDetail(ucVehicleSearch.Notice);
                this.Controls.Add(ucVehicleDetail);
                ucVehicleDetail.Location = new Point(0, 53);
                ucVehicleDetail.Name = "ucVehicleDetail";
                ucVehicleDetail.GoBack += DisplaySearch;
                ucVehicleDetail.BuyClick += DisplayBuy;
                ucVehicleDetail.BringToFront();

                btLogin.BringToFront();
                lblUsername.BringToFront();
            }
        }

        private void DisplayBuy()
        {
            if (user == null)
            {
                MessageBox.Show("Vous devez vous connecter afin de contacter le vendeur !");
            }
            else
            {
                UcVehicleSearch ucVehicleSearch = (UcVehicleSearch)currentUc;
                string mail = ucVehicleSearch.Notice.GetSellerMail();
                if (user.Email == mail)
                {
                    MessageBox.Show("Vous ne pouvez pas acheter votre propre véhicule !"); 
                    return;
                }
                Clipboard.SetText(mail);
                MessageBox.Show($"Vous pouvez contacter le vendeur à l'adresse mail suivante : {mail}\nL'adresse a été copiée dans le presse-papiers. Utiliser ctrl+v pour la coller.");
            }
        }

        // Méthode qui permet de revenir sur la page de recherche lorsque nous sommes dans la page de détail d'une annonce
        private void DisplaySearch()
        {
            currentUc.Visible = true;
            this.Controls.Remove(ucVehicleDetail);
        }

        // Méthode qui affiche la page d'ajout d'une annonce
        private void DisplayAddNotice()
        {
            if (CheckAddOrModify())
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
            ucAddModifyVehicle.DisplaySells += DisplayMySells;
            currentUc = ucAddModifyVehicle;
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        //Méthode qui affiche la page mes ventes
        private void DisplayMySells()
        {
            if (currentUc is UcMySells || CheckAddOrModify())
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcMySells ucMySells = new UcMySells(user);
            this.Controls.Add(ucMySells);
            ucMySells.Location = new Point(0, 53);
            ucMySells.Name = "ucMySells";
            ucMySells.BringToFront();
            ucMySells.ModifyClick += DisplayModifyNotice;
            currentUc = ucMySells;
            btLogin.BringToFront();
            lblUsername.BringToFront();
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
            ucAddModifyVehicle.DisplaySells += DisplayMySells;
            currentUc = ucAddModifyVehicle;
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        private bool CheckAddOrModify()
        {
            if (currentUc is UcAddModifyVehicle)
            {
                UcAddModifyVehicle ucAddModifyVehicle = (UcAddModifyVehicle)currentUc;
                if(!ucAddModifyVehicle.Validate) 
                {
                    DialogResult myResult = MessageBox.Show("Êtes-vous sûr de vouloir quitter le formulaire ? Les changements ne seront pas sauvegardés !", "Confirmation de sortie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (myResult == DialogResult.Yes)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
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
                DisplayHome(true);
            }
        }
    }
}
