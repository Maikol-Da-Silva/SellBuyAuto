/*
 * file          : Notice.cs
 * brief         : This file contains the class of Notice
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
 * update Date   : 07.05.2024
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SellBuyAuto
{
    public class Notice
    {
        // Attributs
        private int idNotice;
        private int idCar;
        private int idBuyer;
        private int idSeller;
        private DateTime publicationDate;
        private DateTime buyDate;
        private int price;
        private bool isActive;
        private bool isBlocked;
        private string brand;
        private string model;
        private int year;
        private int mileage;
        private string description;
        private string engineType;
        private List<Bitmap> images;

        // Constructeurs
        public Notice(int idNotice, int idCar, int idBuyer, int idSeller, DateTime publicationDate, DateTime buyDate, int price, bool isActive, bool isBlocked, 
            string brand, string model, int year, int mileage, string description, string engineType)
        {
            this.idNotice = idNotice;
            this.idCar = idCar;
            this.idBuyer = idBuyer;
            this.idSeller = idSeller;
            this.publicationDate = publicationDate;
            this.buyDate = buyDate;
            this.price = price;
            this.isActive = isActive;
            this.isBlocked = isBlocked;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.description = description;
            this.engineType = engineType;
            this.images = new List<Bitmap>();
        }

        // Pour afficher dans mes achats/ventes
        public Notice(int idNotice, int idCar, int idSeller, DateTime publicationDate, int price, bool isActive, bool isBlocked,
           string brand, string model, int year, int mileage, string description, string engineType)
        {
            this.idNotice = idNotice;
            this.idCar = idCar;
            this.idSeller = idSeller;
            this.publicationDate = publicationDate;
            this.price = price;
            this.isActive = isActive;
            this.isBlocked = isBlocked;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.description = description;
            this.engineType = engineType;
            this.images = new List<Bitmap>();
        }

        // Pour afficher lors des recherches
        public Notice(int idNotice, int idCar, int idSeller, DateTime publicationDate, int price,
           string brand, string model, int year, int mileage, string description, string engineType)
        {
            this.idNotice = idNotice;
            this.idCar = idCar;
            this.idSeller = idSeller;
            this.publicationDate = publicationDate;
            this.price = price;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.description = description;
            this.engineType = engineType;
            this.images = new List<Bitmap>();
        }

        // Accesseurs
        public int IdNotice { get { return idNotice; } }
        public int IdCar { get {  return idCar; } }
        public int IdBuyer { get { return idBuyer; } }
        public int IdSeller { get {  return idSeller; } }
        public DateTime PublicationDate { get {  return publicationDate; } }
        public DateTime BuyDate { get { return buyDate; } }
        public int Price { get { return price; } }
        public bool Active { get { return isActive; } }
        public bool Blocked { get { return isBlocked; } }
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }
        public int Year { get { return year; } }
        public int Mileage { get { return mileage; } }
        public string  Description { get { return description; } }
        public string EngineType { get { return engineType; } }

        // Méthodes

        // Méthode qui permet de récupérer les images à travers une connexion FTP
        public List<Bitmap> GetImages()
        {
            DBConnection db = new DBConnection();

            string images = db.GetImages(idCar);
            string[] imagesList = images.Split('/');
            List<Bitmap> bitmaps = new List<Bitmap>();

            FTPConnection ftp = new FTPConnection();
            foreach (string image in imagesList)
            {
                bitmaps.Add(ftp.GetImage(image));
            }
            this.images = bitmaps;
            return this.images;
        }

        // Méthode qui permet de supprimer les images de la mémoire
        public void ClearImages()
        {
            this.images.Clear();
        }

        // Méthode qui permet de mettre à jour les attributs lors d'une modification
        public void UpdateValues(string brand, string model, string description, int year, int mileage, int price, string engineType)
        {
            this.brand = brand;
            this.model = model;
            this.description = description;
            this.year = year;
            this.mileage = mileage;
            this.price = price;
            this.engineType = engineType;
        }

        public override string ToString()
        {
            return $"{brand} {model}";
        }
    }
}
