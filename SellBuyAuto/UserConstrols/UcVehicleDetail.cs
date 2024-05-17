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
    public partial class UcVehicleDetail : UserControl
    {
        public event Action GoBack;
        public event Action BuyClick;

        Notice notice;
        int currentImage = 0;
        int nbImages;

        public UcVehicleDetail(Notice notice)
        {
            InitializeComponent();
            this.notice = notice;
        }

        private void UcVehicleDetail_Load(object sender, EventArgs e)
        {
            pbImage.Image = notice.GetImages()[currentImage];
            lblBrandModel.Text = notice.ToString();
            lblPrice.Text = $"Prix : {notice.Price} CHF";
            lblYear.Text = $"Année : {notice.Year}";
            lblMileage.Text = $"Kilométrage : {notice.Mileage} km";
            lblEngineType.Text = $"Motorisation : {notice.EngineType}";
            lblDescription.Text = notice.Description;

            nbImages = notice.GetImages().Count;

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            GoBack?.Invoke();
        }

        private void btImageNext_Click(object sender, EventArgs e)
        {
            if (currentImage >= nbImages - 1)
            {
                currentImage = 0;
            }
            else
            {
                currentImage++;
            }
            pbImage.Image = notice.GetImages()[currentImage];
        }

        private void btImagePrevious_Click(object sender, EventArgs e)
        {
            if (currentImage <= 0)
            {
                currentImage = nbImages - 1;
            }
            else
            {
                currentImage--;
            }
            pbImage.Image = notice.GetImages()[currentImage];
        }

        private void btBuy_Click(object sender, EventArgs e)
        {
            BuyClick?.Invoke();
        }
    }
}
