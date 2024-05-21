/*
 * file          : UcVehicleSold.cs
 * brief         : This file contains the code of the UserControl UcVehicleSold
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 17.05.2024
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
    public partial class UcVehicleSold : UserControl
    {
        public event Action Cancel;
        public event Action Validate;

        private User user;
        private User buyer;
        private int noticeId;

        public UcVehicleSold(User user, int noticeId)
        {
            InitializeComponent();
            this.user = user;
            this.noticeId = noticeId;
        }

        public User Buyer { get { return buyer; } }

        private void btValidate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || !FormSignUp.IsValid(txtEmail.Text))
            {
                MessageBox.Show("Vous devez écrire une adresse mail valide");
            }
            else if (txtEmail.Text == user.Email)
            {
                MessageBox.Show("Vous ne pouvez pas vendre votre véhicule à vous-même !");
            }
            else
            {
                DBConnection db = new DBConnection();
                try
                {
                    buyer = db.GetUser(txtEmail.Text);
                    db.AddBuyerToNotices(noticeId, DateTime.Now.ToString("yyyy-MM-dd"), buyer.IdUser);
                    List<int> users = db.GetUsersBookMark(noticeId);
                    foreach (int userId in users)
                    {
                        db.DeleteBookmark(noticeId, userId);
                    }
                    MessageBox.Show($"L'annonce a bien été vendue à {buyer.Username}");
                    Validate?.Invoke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Aucun compte n'est relié à cette adresse mail !");
                }
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btValidate_Click(sender, e);
            }
        }

        private void btValidate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btValidate_Click(sender, e);
            }
        }

        private void UcVehicleSold_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }
    }
}
