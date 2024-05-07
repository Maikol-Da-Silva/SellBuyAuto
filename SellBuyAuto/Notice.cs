﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private List<string> images;

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
            this.images = new List<string>();
        }

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
            this.images = new List<string>();
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

        public void GetImages()
        {
            throw new NotImplementedException();
        }
    }
}