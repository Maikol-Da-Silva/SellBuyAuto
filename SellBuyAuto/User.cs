/*
 * file          : User.cs
 * brief         : This file contains the class of User
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 07.05.2024
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBuyAuto
{
    public class User
    {
        // Attributs
        private int idUser;
        private string email;
        private string username;
        private string password;
        private bool isAdmin;
        private bool isBlocked;
        private List<Notice> bookmarks;
        private List<Notice> sells;
        private List<Notice> purchases;

        // Constructeurs
        public User(int idUser, string email, string username, string password, bool isAdmin, bool isBlocked)
        {
            this.idUser = idUser;
            this.email = email;
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
            this.isBlocked = isBlocked;
            this.bookmarks = new List<Notice>();
            this.sells = new List<Notice>();
            this.purchases = new List<Notice>();
        }

        public User(string email, string username, string password)
        {
            this.email = email;
            this.username = username;
            this.password = password;
            this.isAdmin = false;
            this.isBlocked = false;
        }

        // Accesseurs
        public int IdUser { get { return idUser; } set { idUser = value; } }
        public string Email { get { return email; } }
        public string Username { get { return username;} }
        public string Password { get { return password; } }
        public bool IsBlocked { get { return isBlocked; } }
        public bool IsAdmin { get {  return isAdmin; } }

        // Méthodes

        public void GetBookmarks()
        {
            throw new NotImplementedException();
        }

        public void AddBookmark()
        {
            throw new NotImplementedException();
        }

        public void AddNotice()
        {
            throw new NotImplementedException();
        }

        public void ModifyNotice()
        {
            throw new NotImplementedException();
        }

        public void DeleteNotice()
        {
            throw new NotImplementedException();
        }

        public void AddSaleMade()
        {
            throw new NotImplementedException();
        }

        public void BlockUser()
        {
            throw new NotImplementedException();
        }

        public void BlockNotice()
        {
            throw new NotImplementedException();
        }

        public List<Notice> GetSells()
        {
            if (sells == null || sells.Count == 0)
            {
                DBConnection db = new DBConnection();
                sells = db.GetSells(IdUser);
            }
            return sells;
        }

        public void GetPurchases()
        {
            throw new NotImplementedException();
        }
    }
}
