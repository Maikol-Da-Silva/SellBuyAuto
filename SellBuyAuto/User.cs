/*
 * file          : User.cs
 * brief         : This file contains the class of User
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 24.05.2024
*/

using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            this.bookmarks = new List<Notice>();
            this.sells = new List<Notice>();
            this.purchases = new List<Notice>();
        }

        public User(int idUser, string email, string username, bool isBlocked)
        {
            this.idUser = idUser;
            this.email = email;
            this.username = username;
            this.isBlocked = isBlocked;
            this.bookmarks = new List<Notice>();
            this.sells = new List<Notice>();
            this.purchases = new List<Notice>();
        }

        // Accesseurs
        public int IdUser { get { return idUser; } set { idUser = value; } }
        public string Email { get { return email; } }
        public string Username { get { return username;} }
        public string Password { get { return password; } }
        public bool IsBlocked { get { return isBlocked; } }
        public bool IsAdmin { get {  return isAdmin; } }

        // Méthodes

        public List<Notice> GetBookmarks()
        {
            DBConnection db = new DBConnection(); ;
            try
            {
                if (bookmarks == null || bookmarks.Count == 0)
                {
                    bookmarks = db.GetBookmarks(IdUser);
                }
                return bookmarks;
            }
            catch (Exception e)
            {
                db.CloseConnection();
                return null;
            }
        }

        public bool isNoticeBookmarked(int idNotice)
        {
            if (this.bookmarks == null || this.bookmarks.Count == 0)
            {
                GetBookmarks();
            }
            foreach (Notice notice in bookmarks)
            {
                if (notice.IdNotice == idNotice)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteBookmark(int idNotice)
        {
            if (this.bookmarks != null)
            {
                this.bookmarks.Remove(GetNoticeWithId(this.bookmarks, idNotice));
            }
            DBConnection db = new DBConnection();
            db.DeleteBookmark(idNotice, IdUser);
        }

        public void AddBookmark(Notice notice)
        {
            DBConnection db = new DBConnection();
            db.AddBookmark(notice.IdNotice, IdUser);

            if (this.bookmarks != null)
            {
                this.bookmarks.Add(notice);
            }
        }

        public void AddNotice(string brand, string model, string description, int idEngineType, string engineType, int price, int year, int mileage, string[] imagesNames)
        {
            DBConnection db = new DBConnection();
            int idBrand;
            int idModel;
            int idCar;
            int idNotice;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                idBrand = db.GetId("Brands", brand);
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                idBrand = db.AddBrand(brand);
            }
            try
            {
                idModel = db.GetId("Models", model);
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                idModel = db.AddModel(model, idBrand);
            }
            idCar = db.AddCar(year, mileage, description, idModel, idEngineType);
            idNotice = db.AddNotice(date, price, this.idUser, idCar);
            UploadImages(idCar, imagesNames);
            string images = "";
            for (int i = 1; i <= imagesNames.Length; i++)
            {
                string[] strings = imagesNames[i - 1].Split(".");
                string newImageName = $"{idCar}_{i}.{strings[strings.Length - 1]}";
                images += newImageName + "/";
            }
            images = images.Remove(images.Length - 1);
            db.UpdateImages(images, idCar);

            Notice notice = new Notice(idNotice, idCar, this.idUser, DateTime.Now, price,
            brand, model, year, mileage, description, engineType);
            if(this.sells != null && this.sells.Count > 0)
            {
                this.sells.Add(notice);
            }
        }

        public void ModifyNotice(int idNotice, string brand, string model, string description, int idEngineType, string engineType, int price, int year, int mileage, string[] imagesNames)
        {
            DBConnection db = new DBConnection();
            int idBrand;
            int idModel;
            Notice notice = GetNoticeWithId(this.sells, idNotice);
            try
            {
                idBrand = db.GetId("Brands", brand);
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                idBrand = db.AddBrand(brand);
            }
            try
            {
                idModel = db.GetId("Models", model);
            }
            catch (Exception ex)
            {
                db.CloseConnection();
                idModel = db.AddModel(model, idBrand);
            }
            db.UpdateCars(notice.IdCar, year, mileage, description, idModel, idEngineType);
            db.UpdateNotices(notice.IdCar, price);

            if (imagesNames != null)
            {
                string images = "";
                for (int i = 1; i <= imagesNames.Length; i++)
                {
                    string[] strings = imagesNames[i - 1].Split(".");
                    string newImageName = $"{notice.IdCar}_{i}.{strings[strings.Length - 1]}";
                    images += newImageName + "/";
                }
                images = images.Remove(images.Length - 1);
                db.UpdateImages(images, notice.IdCar);

                UploadImages(notice.IdCar, imagesNames);
            }

            notice.UpdateValues(brand, model, description, year, mileage, price, engineType);


        }

        public void DeleteNotice(int idNotice)
        {
            if (this.sells != null)
            {                
                this.sells.Remove(GetNoticeWithId(this.sells, idNotice));
            }
        }

        public void AddSaleMade()
        {
            throw new NotImplementedException();
        }

        public List<Notice> BlockUser(int sellerId)
        {
            DBConnection db = new DBConnection();
            User userToBlock = db.GetUserFromId(sellerId);
            userToBlock.BlockUserNotices();
            db.BlockUser(userToBlock.IdUser);
            return userToBlock.GetSells();
        }

        public void BlockNotice(Notice notice)
        {
            DBConnection db = new DBConnection();
            db.BlockNotice(notice.IdNotice);
            List<int> users = db.GetUsersBookMark(notice.IdNotice);
            foreach (int userId in users)
            {
                db.DeleteBookmark(notice.IdNotice, userId);
            }
        }

        private void BlockUserNotices()
        {
            GetSells();
            if (this.sells != null && this.sells.Count > 0)
            {
                foreach (Notice notice in this.sells)
                {
                    BlockNotice(notice);
                }
            }
        }

        public List<Notice> GetSells()
        {
            DBConnection db = new DBConnection();
            try
            {
                if (sells == null || sells.Count == 0)
                {
                    
                    sells = db.GetSells(IdUser);
                }
                return sells;
            }
            catch(Exception e)
            {
                db.CloseConnection();
                return null;
            }
            
        }

        public void SetSold(int idNotice, User buyer)
        {
            foreach(Notice notice in sells)
            {
                if (notice.IdNotice == idNotice)
                {
                    notice.SetSold(DateTime.Now, buyer.idUser);
                }
            }
        }

        public List<Notice> GetPurchases()
        {

            DBConnection db = new DBConnection();
            try
            {
                if (purchases == null || purchases.Count == 0)
                {
                    purchases = db.GetPurchases(IdUser);
                }
                return purchases;
            }
            catch (Exception e)
            {
                db.CloseConnection();
                return null;
            }
        }

        // Permet de upload les images en arrière-plan
        private async void UploadImages(int idCar, string[] imagesNames)
        {
            FTPConnection ftp = new FTPConnection();
            await Task.Run(() =>
            {
                for (int i = 1; i <= imagesNames.Length; i++)
                {
                    string[] strings = imagesNames[i - 1].Split(".");
                    string newImageName = $"{idCar}_{i}.{strings[strings.Length - 1]}";
                    ftp.UploadImage(imagesNames[i - 1], newImageName);
                }
            });
        }

        private Notice GetNoticeWithId(List<Notice> list, int idNotice)
        {
            foreach(Notice notice in list)
            {
                if(notice.IdNotice == idNotice)
                {
                    return notice;
                }
            }
            return null;
        }
    }
}
