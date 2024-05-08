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
    public partial class UcHome : UserControl
    {
        public event Action AdvancedSearchClick;

        List<Brand> brands;
        List<Model> models;

        public UcHome()
        {
            InitializeComponent();
        }

        private void UcHome_Load(object sender, EventArgs e)
        {
            foreach (var control in gbQuickSearch.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox cb = (ComboBox)control;
                    cb.SelectedIndex = 0;
                }
            }

            DBConnection db = new DBConnection();
            brands = db.GetBrands();
            foreach (var brand in brands)
            {
                cbBrand.Items.Add(brand);
            }

            models = db.GetModels();
            foreach (var model in models)
            {
                cbModel.Items.Add(model);
            }

            cbModel.Enabled = false;
        }

        private void btAdvancedSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearchClick?.Invoke();
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrand.SelectedIndex != 0)
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Tous");

                Brand brand = (Brand)cbBrand.Items[cbBrand.SelectedIndex];
                foreach (var model in models)
                {
                    if (model.IdBrand == brand.IdBrand)
                    {
                        cbModel.Items.Add(model);
                    }
                }

                cbModel.SelectedIndex = 0;

                cbModel.Enabled = true;
            }
            else if (cbBrand.SelectedIndex == 0 && models != null)
            {
                cbModel.Items.Clear();
                cbModel.Items.Add("Tous");

                foreach (var model in models)
                {
                    cbModel.Items.Add(model);
                }

                cbModel.SelectedIndex = 0;

                cbModel.Enabled = false;
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string request = "";
            if (cbBrand.SelectedIndex != 0)
            {
                request += $" Brands.Name = '{cbBrand.Items[cbBrand.SelectedIndex]}'";
                if (cbModel.SelectedIndex != 0)
                {
                    request += $" AND Models.Name = '{cbModel.Items[cbModel.SelectedIndex]}'";
                }

                request += " AND";
            }

            request += $" Cars.`Year` >= {numYear.Value} AND Notices.Price <= {numPrice.Value}";

            try
            {
                DBConnection db = new DBConnection();
                List<Notice> notices = db.GetNotices(request);
                foreach (Notice notice in notices)
                {
                    MessageBox.Show(notice.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aucune voiture n'a été trouvée avec ces critères !");
            }            
        }
    }
}
