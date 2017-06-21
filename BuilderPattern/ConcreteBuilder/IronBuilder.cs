using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Product;

namespace BuilderPattern.ConcreteBuilder
{
    class IronBuilder : ArmorBuilder
    {
        public override void SetAccessories()
        {
            armor.Accessories.Add("Missiles");
            armor.Accessories.Add("Laser");
            armor.Accessories.Add("Shield");
            armor.Accessories.Add("Arc reactor");
        }

        public override void SetBody()
        {
            armor.Body = "Iron";
        }

        public override void SetColor()
        {
            armor.Color = "Blue";
        }

        public override void SetHelmet()
        {
            armor.Helmet = "Heavy";
        }

        public override void SetModel()
        {
            armor.Model = "Iron Copy";
        }
    }

}
