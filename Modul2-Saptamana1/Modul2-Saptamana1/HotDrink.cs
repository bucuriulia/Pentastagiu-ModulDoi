using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Saptamana1
{
    public class HotDrink : Drink
    {
        public HotDrink(int id, int quantity, double price, string name, string description) : base(id, quantity, price, name, description)
        {
        }
    }
}
