/*
 * file          : UcLogin.cs
 * brief         : This file contains the code of the UserControl UcLogin
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 24.05.2024
 * update Date   : 24.05.2024
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace SellBuyAuto.UserConstrols
{
    public partial class UcLogin : UserControl
    {
        public event Action SignUpClick;
        public event Action CloseLogin;

        private User user;

        public User User
        {
            get { return user; }
        }

        public UcLogin()
        {
            InitializeComponent();
        }

        //Fonction qui permet d'attendre un certain nombre de temps
        public static void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public static string GetHash(string password)
        {
            byte[] tmpSource;
            byte[] tmpHash;
            //Create a byte array from source data.
            tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
            //Compute hash based on source data.
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            StringBuilder sOutput = new StringBuilder(tmpHash.Length);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                sOutput.Append(tmpHash[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        //Fonction qui permet d'afficher le mdp pendant 2 sec lors du clique du bouton
        private void btShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                Wait(2000);
                txtPassword.PasswordChar = '*';
            }
        }

        //Fonction qui ouvre le formulaire d'enregistrement
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpClick?.Invoke();
        }

        //Fonction qui check le login dans la base de données
        private void btLogin_Click(object sender, EventArgs e)
        {
            //check si l'un des deux champs n'est pas vide
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    DBConnection db = new DBConnection();
                    user = db.GetLogin(txtUsername.Text);

                    //Check le hash du mot de passe et le compare à celui qui est stocké dans la BDD
                    if (user.Password == GetHash(txtPassword.Text))
                    {
                        if(user.IsBlocked)
                        {
                            MessageBox.Show("Votre compte a été bloqué par un administrateur !");
                        }
                        else 
                        {

                            CloseLogin?.Invoke();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mauvais Nom d'utilisateur / Email ou Mot de passe !");
                }

            }
            else
            {
                MessageBox.Show("Un des champs n'est pas rempli !");
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);
            }
        }

        private void btShowPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void UcLogin_Enter(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}
