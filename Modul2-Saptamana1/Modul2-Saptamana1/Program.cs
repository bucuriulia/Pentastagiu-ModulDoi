using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2_Saptamana1
{
    class Program
    {
        private static int DisplayOptions()
        {
            Console.Write("\n1. View menu items\n" +
                            "2. Add new item \n" +
                            "3. Edit existing item \n" +
                            "4. Delete existing item \n" +
                            "Your option: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static MenuItem CreateMenuItem()
        {
            Console.WriteLine("1. Chicken burger \n2. Vegan burger \n3. Hot drink \n4. Cold drink");
            var menuType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item id: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item name: ");
            var name = Console.ReadLine();
            Console.Write("Item quantity: ");
            var quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item price: ");
            var price = Convert.ToDouble(Console.ReadLine());
            var description = Console.ReadLine();

            switch (menuType)
            {
                case 1:
                    return new ChickenBurger(id, quantity, price, name, description);
                case 2:
                    return new VegBurger(id, quantity, price, name, description);
                case 3:
                    return new HotDrink(id, quantity, price, name, description);
                case 4:
                    return new ColdDrink(id, quantity, price, name, description);
                default:
                    return null;
            }
        }

        static void Main()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"Welcome to {Restaurant.Name}");

            var option = DisplayOptions();

            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        restaurant.DisplayMenuItems();

                        option = DisplayOptions();
                        break;
                    case 2:
                        var menuItem = CreateMenuItem();
                        while (menuItem == null)
                        { Console.WriteLine("Invalid input"); menuItem = CreateMenuItem(); }

                        if (restaurant.Create(menuItem))
                            Console.WriteLine("Menu item successfully added");
                        else
                            Console.WriteLine("Menu item already exists");

                        option = DisplayOptions();
                        break;
                    case 3:
                        menuItem = CreateMenuItem();
                        while (menuItem == null)
                        { Console.WriteLine("Invalid input"); menuItem = CreateMenuItem(); }

                        if (restaurant.Edit(menuItem))
                            Console.WriteLine("Menu item successfully edited");
                        else
                            Console.WriteLine("Menu item already exists");

                        option = DisplayOptions();
                        break;
                    case 4:
                        Console.Write("Item id: ");
                        var id = Convert.ToInt32(Console.ReadLine());

                        restaurant.Delete(id);

                        option = DisplayOptions();
                        break;
                    default:
                        break;
                }
            }


            Console.ReadKey();
        }
    }
}
