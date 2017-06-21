using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    interface IArmorBuilder
    {
        void SetHelmet();
        void SetModel();
        void SetBody();
        void SetColor();
        void SetAccessories();
        Armor GetArmor();

    }
}
