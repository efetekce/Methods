using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CartManager
    {
        public void Add(Product prod)
        {
            Console.WriteLine($"{prod.Name} was added to the cart.");
        }

        public void Remove(string prodName, string desc, double prodPrice)
        {
            Console.WriteLine($"{prodName} was removed from the cart.");
        }
    }
}
