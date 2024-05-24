/*
 * file          : FormMain.cs
 * brief         : This file contains the code of the controls in the FormMain
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 24.05.2024
*/

using Mysqlx.Crud;
using SellBuyAuto.UserConstrols;

namespace SellBuyAuto
{
    public partial class FormMain : Form
    {
        User user;
        UserControl currentUc;
        UcVehicleDetail ucVehicleDetail;
        UcLogin ucLogin;
        UcSignUp ucSignUp;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DisplayHome();

        }

        private void CheckPages()
        {
            if (ucLogin != null)
            {
                this.Controls.Remove(ucLogin);
                ucLogin = null;
                if (ucSignUp != null)
                {
                    this.Controls.Remove(ucSignUp);
                    ucSignUp = null;
                }
            }
            if(ucVehicleDetail != null)
            {
                this.Controls.Remove(ucVehicleDetail);
                ucVehicleDetail = null;
            }
        }

        // M�thode qui affiche la page d'accueil
        private void DisplayHome(bool cont = false)
        {
            CheckPages();
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
            ucHome.Location = new Point(0, 53);
            ucHome.Name = "ucHome";
            ucHome.BringToFront();
            ucHome.AdvancedSearchClick += DisplayAdvancedSearch;
            ucHome.SearchClick += DisplayQuickSearchResult;
            currentUc = ucHome;
            this.Controls.Add(ucHome);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        // M�thode qui affiche la page contenant les r�sultats de la recherche rapide
        private void DisplayQuickSearchResult()
        {
            if (currentUc != null)
            {
                UcHome ucHome = (UcHome)currentUc;

                this.Controls.Remove(currentUc);
                DisplaySearch(ucHome.Notices);
            }
        }

        // M�thode qui affiche la page de recherche avanc�e
        private void DisplayAdvancedSearch()
        {
            CheckPages();
            if (currentUc is UCAdvancedSearch || CheckAddOrModify())
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UCAdvancedSearch ucAdvancedSearch = new UCAdvancedSearch();
            ucAdvancedSearch.Location = new Point(0, 53);
            ucAdvancedSearch.Name = "ucAdvancedSearch";
            ucAdvancedSearch.BringToFront();
            ucAdvancedSearch.SearchClick += DisplayAdvancedSearchResult;
            currentUc = ucAdvancedSearch;
            this.Controls.Add(ucAdvancedSearch);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        // M�thode qui affiche la page contenant les r�sultats de la recherche avanc�e
        private void DisplayAdvancedSearchResult()
        {
            if (currentUc != null)
            {
                UCAdvancedSearch ucAdvancedSearch = (UCAdvancedSearch)currentUc;

                this.Controls.Remove(currentUc);
                DisplaySearch(ucAdvancedSearch.Notices);

            }
        }

        private void DisplaySearch(List<Notice> notices, int currentPage = 1)
        {
            UcVehicleSearch ucVehicleSearch = new UcVehicleSearch(notices, user, currentPage);
            ucVehicleSearch.Location = new Point(0, 53);
            ucVehicleSearch.Name = "ucVehicleSearch";
            ucVehicleSearch.BringToFront();
            ucVehicleSearch.DisplayDetail += DisplayVehicleDetail;
            currentUc = ucVehicleSearch;
            this.Controls.Add(ucVehicleSearch);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        // M�thode qui permet d'afficher le d�tail d'une annonce
        private void DisplayVehicleDetail()
        {
            if (currentUc != null)
            {
                currentUc.Visible = false;


                if (ucVehicleDetail != null)
                {
                    ucVehicleDetail = null;
                }

                if (currentUc is UcVehicleSearch)
                {
                    UcVehicleSearch ucVehicleSearch = (UcVehicleSearch)currentUc;
                    ucVehicleDetail = new UcVehicleDetail(ucVehicleSearch.Notice);
                }
                else
                {
                    UcMyBookmarks ucMyBookmarks = (UcMyBookmarks)currentUc;
                    ucVehicleDetail = new UcVehicleDetail(ucMyBookmarks.Notice);
                }
                DisplayDetail();
            }
        }

        private void DisplayDetail()
        {
            ucVehicleDetail.Location = new Point(0, 53);
            ucVehicleDetail.Name = "ucVehicleDetail";
            ucVehicleDetail.GoBack += DisplaySearch;
            ucVehicleDetail.BuyClick += DisplayBuy;
            this.Controls.Add(ucVehicleDetail);
            ucVehicleDetail.BringToFront();

            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        private void DisplayBuy()
        {
            if (user == null)
            {
                MessageBox.Show("Vous devez vous connecter afin de contacter le vendeur !");
            }
            else
            {
                string mail;
                if (currentUc is UcVehicleSearch)
                {
                    UcVehicleSearch ucVehicleSearch = (UcVehicleSearch)currentUc;
                    mail = ucVehicleSearch.Notice.GetSellerMail();
                }
                else
                {
                    UcMyBookmarks ucMyBookmarks = (UcMyBookmarks)currentUc;
                    mail = ucMyBookmarks.Notice.GetSellerMail();
                }
                if (user.Email == mail)
                {
                    MessageBox.Show("Vous ne pouvez pas acheter votre propre v�hicule !");
                    return;
                }
                Clipboard.SetText(mail);
                MessageBox.Show($"Vous pouvez contacter le vendeur � l'adresse mail suivante : {mail}\nL'adresse a �t� copi�e dans le presse-papiers. Utiliser ctrl+v pour la coller.");
            }
        }

        // M�thode qui permet de revenir sur la page de recherche lorsque nous sommes dans la page de d�tail d'une annonce
        private void DisplaySearch()
        {
            currentUc.Visible = true;
            this.Controls.Remove(ucVehicleDetail);
        }

        // M�thode qui affiche la page d'ajout d'une annonce
        private void DisplayAddNotice()
        {
            CheckPages();
            if (CheckAddOrModify())
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcAddModifyVehicle ucAddModifyVehicle = new UcAddModifyVehicle(user);
            ucAddModifyVehicle.Location = new Point(0, 53);
            ucAddModifyVehicle.Name = "ucAddModifyVehicle";
            ucAddModifyVehicle.BringToFront();
            ucAddModifyVehicle.DisplaySells += DisplayMySells;
            currentUc = ucAddModifyVehicle;
            this.Controls.Add(ucAddModifyVehicle);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        //M�thode qui affiche la page mes ventes
        private void DisplayMySells()
        {
            CheckPages();
            if (currentUc is UcMySells || CheckAddOrModify())
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcMySells ucMySells = new UcMySells(user);
            ucMySells.Location = new Point(0, 53);
            ucMySells.Name = "ucMySells";
            ucMySells.BringToFront();
            ucMySells.ModifyClick += DisplayModifyNotice;
            currentUc = ucMySells;
            this.Controls.Add(ucMySells);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        // M�thode qui affiche la page de modification
        private void DisplayModifyNotice()
        {
            UcMySells ucMySells = (UcMySells)currentUc; ;
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcAddModifyVehicle ucAddModifyVehicle = new UcAddModifyVehicle(user, ucMySells.NoticeToModify);
            ucAddModifyVehicle.Location = new Point(0, 53);
            ucAddModifyVehicle.Name = "ucAddModifyVehicle";
            ucAddModifyVehicle.BringToFront();
            ucAddModifyVehicle.DisplaySells += DisplayMySells;
            currentUc = ucAddModifyVehicle;
            this.Controls.Add(ucAddModifyVehicle);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        private bool CheckAddOrModify()
        {
            if (currentUc is UcAddModifyVehicle)
            {
                UcAddModifyVehicle ucAddModifyVehicle = (UcAddModifyVehicle)currentUc;
                if (!ucAddModifyVehicle.Validate)
                {
                    DialogResult myResult = MessageBox.Show("�tes-vous s�r de vouloir quitter le formulaire ? Les changements ne seront pas sauvegard�s !", "Confirmation de sortie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        //M�thode qui affiche la page favoris
        private void DisplayMyBookmarks()
        {
            CheckPages();
            if (currentUc is UcMyBookmarks || CheckAddOrModify())
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcMyBookmarks ucMyBookmarks = new UcMyBookmarks(user);
            ucMyBookmarks.Location = new Point(0, 53);
            ucMyBookmarks.Name = "ucMyBookmarks";
            ucMyBookmarks.BringToFront();
            ucMyBookmarks.DisplayDetail += DisplayVehicleDetail;
            currentUc = ucMyBookmarks;
            this.Controls.Add(ucMyBookmarks);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        //M�thode qui affiche la page mes achats
        private void DisplayMyPurchases()
        {
            CheckPages();
            if (currentUc is UcMyPurchases || CheckAddOrModify())
            {
                return;
            }
            if (currentUc != null)
            {
                this.Controls.Remove(currentUc);
            }
            UcMyPurchases ucMyPurchases = new UcMyPurchases(user);
            ucMyPurchases.Location = new Point(0, 53);
            ucMyPurchases.Name = "ucMyPurchases";
            ucMyPurchases.BringToFront();
            ucMyPurchases.DisplayDetail += DisplayVehicleDetailFromPurchases;
            currentUc = ucMyPurchases;
            this.Controls.Add(ucMyPurchases);
            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        private void DisplayVehicleDetailFromPurchases()
        {
            if (ucVehicleDetail != null)
            {
                ucVehicleDetail = null;
            }

            UcMyPurchases ucMyPurchases = (UcMyPurchases)currentUc;
            ucVehicleDetail = new UcVehicleDetail(ucMyPurchases.Notice, false);

            DisplayDetail();
        }

        private void DisplayLogin()
        {
            currentUc.Visible = false;
            if (ucLogin != null)
            {
                ucLogin = null;
            }

            ucLogin = new UcLogin();
            ucLogin.Location = new Point(0, 53);
            ucLogin.Name = "ucLogin";
            ucLogin.SignUpClick += DisplaySignUp;
            ucLogin.CloseLogin += CloseLogin;
            ucLogin.BringToFront();
            this.Controls.Add(ucLogin);
            ucLogin.Focus();

            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        private void DisplaySignUp()
        {
            ucLogin.Visible = false;
            if (ucSignUp != null)
            {
                ucSignUp = null;
            }

            ucSignUp = new UcSignUp();
            ucSignUp.Location = new Point(0, 53);
            ucSignUp.Name = "ucSignUp";
            ucSignUp.CloseLogin += CloseLogin;
            ucSignUp.BringToFront();
            ucSignUp.Focus();
            this.Controls.Add(ucSignUp);

            btLogin.BringToFront();
            lblUsername.BringToFront();
        }

        private void CloseLogin()
        {
            if (ucSignUp != null)
            {
                if (ucSignUp.User != null)
                {
                    user = ucSignUp.User;
                }
                this.Controls.Remove(ucSignUp);
                ucSignUp = null;
            }
            if (ucLogin != null)
            {
                if (ucLogin.User != null)
                {
                    user = ucLogin.User;
                }
                this.Controls.Remove(ucLogin);
                ucLogin = null;
            }
            if (user != null)
            {
                lblUsername.Text = user.Username;
                btLogin.Text = "Se d�connecter";
                menuStripWithoutLogin.Enabled = false;
                menuStripWithoutLogin.Visible = false;
                menuStripWithLogin.Enabled = true;
                menuStripWithLogin.Visible = true;
                if (currentUc is UcVehicleSearch)
                {
                    UcVehicleSearch ucVehicleSearch = (UcVehicleSearch)currentUc;
                    List<Notice> notices = ucVehicleSearch.Notices;
                    int currentPage = ucVehicleSearch.CurrentPage;
                    currentUc = null;
                    DisplaySearch(notices, currentPage);
                }
            }
            currentUc.Visible = true;
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

        private void favorisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayMyBookmarks();
        }

        private void mesAchatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayMyPurchases();
        }

        private void EnableAllControls(bool enable)
        {
            foreach(Control control in this.Controls)
            {
                control.Enabled = enable;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (btLogin.Text == "Se connecter")
            {
                DisplayLogin();
                /*FormLogin frmLogin = new FormLogin();
                EnableAllControls(false);
                Task t = Task.Run(() => { frmLogin.ShowDialog(this); });
                t.Wait();
                EnableAllControls(true);
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
                    if (currentUc is UcVehicleSearch)
                    {
                        UcVehicleSearch ucVehicleSearch = (UcVehicleSearch)currentUc;
                        List<Notice> notices = ucVehicleSearch.Notices;
                        int currentPage = ucVehicleSearch.CurrentPage;
                        currentUc = null;
                        DisplaySearch(notices, currentPage);
                    }
                }*/
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
