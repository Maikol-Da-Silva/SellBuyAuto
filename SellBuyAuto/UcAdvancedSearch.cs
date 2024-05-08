﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SellBuyAuto
{
    public partial class UCAdvancedSearch : UserControl
    {
        List<Brand> brands;
        List<Model> models;
        public UCAdvancedSearch()
        {
            InitializeComponent();
        }

        private void UCAdvancedSearch_Load(object sender, EventArgs e)
        {
            foreach (var control in gbAdvancedSearch.Controls)
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

            List<string> engineTypes = db.GetEngineTypes();
            foreach (var engineType in engineTypes)
            {
                cbEngineType.Items.Add(engineType);
            }
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

        private void numYearFrom_ValueChanged(object sender, EventArgs e)
        {
            numYearTo.Minimum = numYearFrom.Value;
        }

        private void numYearTo_ValueChanged(object sender, EventArgs e)
        {
            numYearFrom.Maximum = numYearTo.Value;
        }

        private void numMileageFrom_ValueChanged(object sender, EventArgs e)
        {
            numMileageTo.Minimum = numMileageFrom.Value;
        }

        private void numMileageTo_ValueChanged(object sender, EventArgs e)
        {
            numMileageFrom.Maximum = numMileageTo.Value;
        }

        private void numPriceFrom_ValueChanged(object sender, EventArgs e)
        {
            numPriceTo.Minimum = numPriceFrom.Value;
        }

        private void numPriceTo_ValueChanged(object sender, EventArgs e)
        {
            numPriceFrom.Maximum = numPriceTo.Value;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string request = "";

            request += $" Cars.Year >= {numYearFrom.Value} AND Cars.Year <= {numYearTo.Value} " +
                $"AND Notices.Price >= {numPriceFrom.Value} AND Notices.Price <= {numPriceTo.Value} " +
                $"AND Cars.mileage >= {numMileageFrom.Value} AND Cars.mileage <= {numMileageTo.Value} ";

            if (cbEngineType.SelectedIndex != 0)
            {
                request += $" AND EngineTypes.Type = '{cbEngineType.Items[cbEngineType.SelectedIndex]}'";
            }

            if (cbBrand.SelectedIndex != 0)
            {
                request += $" AND Brands.Name = '{cbBrand.Items[cbBrand.SelectedIndex]}'";
                if (cbModel.SelectedIndex != 0)
                {
                    request += $" AND Models.Name = '{cbModel.Items[cbModel.SelectedIndex]}'";
                }
            }

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