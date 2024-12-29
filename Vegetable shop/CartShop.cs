using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_15._1.Vegetable_shop
{
    public class CartShop : Product
    {

        List<Product> products = new List<Product>();

        public void AddProduct(List<Product> product)
        {
            products.AddRange(product);
        }

        public void InfoCart()
        {
            int totalPrice = 0;
            foreach (var item in products)
            {
                Console.WriteLine($"Product: {item.GetType().Name}, Price: {item.Price}");
                totalPrice += item.Price;
            }

            Console.WriteLine($"Total Price: {totalPrice}");

        }
    }
}
