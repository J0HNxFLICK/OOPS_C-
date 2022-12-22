using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ItalianChef : Chef
    {
        public void MakeFrenchFries()
        {
            Console.WriteLine("Cooks french Fries");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("Cooks Ratatouille.");
        }
    }
}
