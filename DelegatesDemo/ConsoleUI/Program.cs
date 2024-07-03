using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert):C2}");

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");

        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Sereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Susu", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Stroberi", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberi", Price = 8.84M });

        }
    }
}
