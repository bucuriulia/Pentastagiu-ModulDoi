namespace Modul2_Saptamana1
{
    public abstract class MenuItem
    {
        protected MenuItem(int id, int quantity, double price, string name, string description)
        {
            Id = id;
            Quantity = quantity;
            Price = price;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"-------------------\n" +
                $"Menu item #{Id} - {Name} \n" +
                $"Quantity: {Quantity} \n" +
                $"Price: {Price} \n" +
                $"Description: {Description}\n" +
                $"-------------------";
        }
    }
}
