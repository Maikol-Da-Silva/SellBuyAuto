namespace SellBuyAuto
{
    public partial class formHome : Form
    {
        User user;
        public formHome()
        {
            InitializeComponent();
        }

        private void formHome_Load(object sender, EventArgs e)
        {
            cbBrand.SelectedIndex = 0;
            cbModel.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
            cbPrice.SelectedIndex = 0;
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
                }
            }
            else
            {
                user = null;
                lblUsername.Text = "";
                btLogin.Text = "Se connecter";
            }
        }
    }
}
