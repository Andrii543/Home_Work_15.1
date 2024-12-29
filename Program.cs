using Home_Work_15._1.Vegetable_shop;

namespace Home_Work_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Carrot(15),
                new Potato(20,4),
                new Cucumber(14,2)
            };


            CartShop cartShop = new CartShop();

            cartShop.AddProduct(products);

            cartShop.InfoCart();
        }
    }
}
