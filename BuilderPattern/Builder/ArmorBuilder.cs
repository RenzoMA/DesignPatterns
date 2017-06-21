using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Product;

namespace BuilderPattern.Builder
{
    public abstract class ArmorBuilder : IArmorBuilder
    {
        protected Armor armor;
        public ArmorBuilder()
        {
            armor = new Armor();
        }
        public Armor GetArmor()
        {
            return armor;
        }

        public abstract void SetAccessories();

        public abstract void SetBody();

        public abstract void SetColor();

        public abstract void SetHelmet();

        public abstract void SetModel();
    }
}
