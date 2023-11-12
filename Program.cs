namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            product.Name = "Macbook";
            product.Price = 15000;
            product.Description = "m3 max";

            Product product2 = new Product();
            product2.Name = "Orange";
            product2.Price = 40;
            product2.Description = "fresh orange";

            Product[] products = new Product[] { product, product2 };

            foreach (Product p in products)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Price);
                Console.WriteLine(p.Description);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("----METHODS----");

            CartManager cartManager = new CartManager();
            cartManager.Add(product);
            cartManager.Add(product2);

            cartManager.Remove("Magic Mouse", "Apple's Touch Mouse", 22000);
        }
    }
}