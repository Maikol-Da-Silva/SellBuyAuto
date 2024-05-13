/*
 * file          : UcVehicleLabel.cs
 * brief         : This file contains the code of the UserControl UcVehicleLabel
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 13.05.2024
 * update Date   : 13.05.2024
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
    public partial class UcVehicleLabel : UserControl
    {
        Notice notice;
        public UcVehicleLabel(Notice notice)
        {
            InitializeComponent();
            this.notice = notice;
        }

        // Méthode qui permet de mettre en place les informations de l'annonce ainsi que l'image
        private void UcVehicleLabel_Load(object sender, EventArgs e)
        {
            lblTitle.Text = notice.ToString();
            lblInfo.Text = $"Kilométrage : {notice.Mileage}  Année : {notice.Year}  Prix : {notice.Price}";
            lblDescription.Text = notice.Description;
            GetImages();

        }

        // Méthode qui permet de récupérer les images en arrière-plan
        async void GetImages()
        {
            await Task.Run(() => { pbVehicleImage.Image = notice.GetImages()[0];});
        }
    }
}
