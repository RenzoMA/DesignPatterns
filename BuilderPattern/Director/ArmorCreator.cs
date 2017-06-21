using BuilderPattern.Builder;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Director
{
    class ArmorCreator
    {
        private IArmorBuilder armorBuilder;
        public ArmorCreator(IArmorBuilder builder)
        {
            armorBuilder = builder;
        }

        public void CreateArmor()
        {
            armorBuilder.SetAccessories();
            armorBuilder.SetBody();
            armorBuilder.SetColor();
            armorBuilder.SetHelmet();
            armorBuilder.SetModel();
        }

        public Armor GetArmor()
        {
            return armorBuilder.GetArmor();
        }
    }
}
