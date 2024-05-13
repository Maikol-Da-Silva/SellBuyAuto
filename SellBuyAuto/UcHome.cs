/*
 * file          : UcHome.cs
 * brief         : This file contains the code of the UserControl UcHome
 * author        : Created by Maikol Correia Da Silva
 * creation Date : 07.05.2024
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
    public partial class UcHome : UserControl
    {
        public event Action AdvancedSearchClick;
        public event Action SearchClick;

        List<Brand> brands;
        List<Model> models;
        List<Notice> notices;

        public UcHome()
        {
            InitializeComponent();
        }

        public List<Notice> Notices { get { return notices; } }

        // Méthode qui s'exécute lorsque le UserControl se lance et qui permet de récupérer les champs à mettre dans les comboBox
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

        // Méthode qui permet d'affiché la recherche avancé. Lance la méthode qui est définie dans le FormMain
        private void btAdvancedSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearchClick?.Invoke();
        }

        // Méthode qui permet d'affiché les modèles liés à la marque sélectionnée
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

        // Méthode qui permet de lancé la recherche
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
                notices = db.GetNotices(request);

                SearchClick?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aucune voiture n'a été trouvée avec ces critères !");
            }    
        }
    }
}
