﻿using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;
using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ironArmorCreator = new ArmorCreator(new IronBuilder());
            ironArmorCreator.CreateArmor();
            var ironArmor = ironArmorCreator.GetArmor();
            ShowDetail(ironArmor);
            Console.WriteLine("\n ---------- \n");

            var robocopArmorCreator = new ArmorCreator(new RobocopBuilder());
            robocopArmorCreator.CreateArmor();
            var robocopArmor = robocopArmorCreator.GetArmor();
            ShowDetail(robocopArmor);
            Console.ReadKey();

        }
        static void ShowDetail(Armor armor)
        {
            Console.WriteLine("Model: {0}", armor.Model);
            Console.WriteLine("Helmet: {0}", armor.Helmet);
            Console.WriteLine("Color: {0}", armor.Color);
            Console.WriteLine("Body: {0}", armor.Body);
            armor.Accessories.ForEach(accessory => Console.WriteLine("Accessories: {0}", accessory));
        }
    }
}
