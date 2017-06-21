using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ConcreteBuilder
{
    class RobocopBuilder : ArmorBuilder
    {
        public override void SetAccessories()
        {
            armor.Accessories.Add("Watch");
            armor.Accessories.Add("Pistol");
            armor.Accessories.Add("Glasses");
        }

        public override void SetBody()
        {
            armor.Body = "Titanium";
        }

        public override void SetColor()
        {
            armor.Color = "Green";
        }

        public override void SetHelmet()
        {
            armor.Helmet = "Baseball helmet";
        }

        public override void SetModel()
        {
            armor.Model = "Sport Robocop";
        }
    }
}
