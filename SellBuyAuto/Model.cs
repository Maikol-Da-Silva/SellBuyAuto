using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellBuyAuto
{
    public class Model
    {
        // Attributs
        private int idBrand;
        private int idModel;
        private string name;

        // Constructeur
        public Model(int idBrand, int idModel, string name)
        {
            this.idBrand = idBrand;
            this.idModel = idModel;
            this.name = name;
        }

        // Accesseurs
        public int IdBrand { get { return idBrand; } }
        public int IdModel { get { return idModel; } }
        public string Name { get { return name; } }

        // Méthode

        public override string ToString()
        {
            return name;
        }
    }
}
