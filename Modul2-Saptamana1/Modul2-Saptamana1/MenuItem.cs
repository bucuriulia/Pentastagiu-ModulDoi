namespace Modul2_Saptamana1
{
    public abstract class MenuItem
    {
        protected MenuItem(int quantity, double price, string name, string description)
        {
            Quantity = quantity;
            Price = price;
            Name = name;
            Description = description;
        }

        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }
}
