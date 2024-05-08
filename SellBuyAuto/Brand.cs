using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBuyAuto
{
    public class Brand
    {
        // Attributs
        private int idBrand;
        private string name;

        // Constructeur
        public Brand(int idBrand, string name)
        {
            this.idBrand = idBrand;
            this.name = name;
        }

        // Accesseurs
        public int IdBrand { get { return idBrand; } }
        public string Name { get { return name; } }

        // Méthode

        public override string ToString()
        {
            return name;
        }
    }
}
