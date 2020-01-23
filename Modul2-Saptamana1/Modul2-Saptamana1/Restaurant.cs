using System.Collections.Generic;
using System.Linq;

namespace Modul2_Saptamana1
{
    public abstract class Restaurant
    {
        public List<MenuItem> MenuItems { get; private set; }
        public abstract bool Create(MenuItem item);
        //{
        //    var menuItem = MenuItems.SingleOrDefault(a => a.Equals(item));
        //    if (menuItem != null)
        //        return false;

        //    MenuItems.Add(item);
        //    return true;
        //}
        public abstract bool Delete(int id);
    }
}
