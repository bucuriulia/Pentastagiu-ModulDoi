using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Saptamana1
{
    public class Restaurant : IRestaurant
    {
        public static string Name = "Restaurant";
        public Restaurant()
        {
            menuItems = new List<MenuItem>
            {
                new ChickenBurger(1, 200, 20, "Burger1", "Description1"),
                new ColdDrink(2, 450, 14, "Drink1", "Description2"),
                new HotDrink(3, 450, 15, "Drink2", "Description3"),
                new ChickenBurger(4, 350, 25, "Burger2", "Description4"),
                new VegBurger(5, 245, 19, "Burger3", "Description5"),
                new ColdDrink(6, 324, 34, "Drink3", "Description6")
            };
        }

        public override bool Create(MenuItem item)
        {
            var menuItem = menuItems.SingleOrDefault(a => a.Id == item.Id);
            if (menuItem != null)
                return false;

            menuItems.Add(item);
            return true;
        }

        public override bool Delete(int id)
        {
            var menuItem = menuItems.SingleOrDefault(a => a.Id == id);
            if (menuItem == null)
                return false;

            menuItems.Remove(menuItem);
            return true;
        }

        public override bool Edit(MenuItem item)
        {
            var menuItem = menuItems.SingleOrDefault(a => a.Id == item.Id);
            if (menuItem != null)
                return false;

            menuItem = item;
            return true;
        }

        public override List<MenuItem> GetAll()
        {
            return menuItems;
        }

        public override MenuItem GetById(int id)
        {
            return menuItems.SingleOrDefault(a => a.Id == id);
        }

        public void DisplayMenuItems()
        {
            foreach (var item in menuItems)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
