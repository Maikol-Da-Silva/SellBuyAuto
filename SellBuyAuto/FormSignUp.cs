/*
 * file          : FormSignUp.cs
 * brief         : This file contains the code of the controls in the FormSignUp
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 07.05.2024
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellBuyAuto
{
    public partial class FormSignUp : Form
    {
        private User user;

        public User User
        {
            get { return user; }
        }

        public FormSignUp()
        {
            InitializeComponent();
        }

        //Fonction qui permet de définir si une adresse mail est valide ou non
        public static bool IsValid(string email)
        {
            var valid = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }

            return valid;
        }

        //Fonction qui valide l'enregistrement
        private void btSignUp_Click(object sender, EventArgs e)
        {
            if (IsValid(txtEmail.Text))
            {
                //Check si aucun des champs n'est vide
                if (txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "")
                {
                    if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.Text != "")
                    {
                        user = new User(txtEmail.Text, txtUsername.Text, FormLogin.GetHash(txtPassword.Text));
                        try
                        {
                            DBConnection db = new DBConnection();
                            user.IdUser = db.AddUser(user);
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Un compte avec ce nom d'utilisateur ou adresse mail existe déjà !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Les deux mots de passe ne correspondent pas !");
                    }

                }
                else
                {
                    MessageBox.Show("Un des champs n'est pas rempli !");
                }
            }
            else
            {
                MessageBox.Show("L'adresse mail n'est pas valide !");
            }

        }

        //Fonction qui permet d'afficher le mot de passe pendant 2 sec
        private void btShowPassword_Click(object sender, EventArgs e)
        {
            TextBox txtbox;
            if (sender == btShowPassword)
            {
                txtbox = txtPassword;
            }
            else
            {
                txtbox = txtConfirmPassword;
            }
            if (txtbox.PasswordChar == '*')
            {
                txtbox.PasswordChar = '\0';
                FormLogin.Wait(2000);
                txtbox.PasswordChar = '*';
            }
        }
        //Fonction qui permet de se connecter si on appuie sur enter
        private void FormSignUp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSignUp_Click(sender, e);
            }
        }

        private void btShowPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btShowPassword2_Enter(object sender, EventArgs e)
        {
            txtConfirmPassword.Focus();
        }
    }
}
