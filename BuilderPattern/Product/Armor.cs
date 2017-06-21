using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    public class Armor
    {
        public string Helmet { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public string Color { get; set; }
        public List<String> Accessories { get; set; }
        public Armor()
        {
            Accessories = new List<string>();
        }


    }
}
