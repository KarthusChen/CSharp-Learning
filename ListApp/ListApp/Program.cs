namespace ListApp
{
    internal class Program
    {
        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }


        static void Main(string[] args)
        {
            List<Product> list = new List<Product>
            {
                new Product{Name="Apple",Price = 0.80},
                new Product{Name="Banana",Price = 0.30},
                new Product{Name="Cherry", Price= 3.80 }
            };

            list.Add(new Product { Name = "Berry", Price = 4.50 });

            List<Product> CheapProduct= list.Where(p=>p.Price<=1.0).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
            }
            Console.WriteLine("The Cheap Items Are:");
            foreach (var item in CheapProduct)
            {

            Console.WriteLine(item.Name);
            Console.WriteLine(item.Price);}

            Console.ReadLine();
        }
    }
}
