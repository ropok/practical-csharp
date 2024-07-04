﻿using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static ShoppingCartModel cart = new ShoppingCartModel();
        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLeveledDiscount, AlertUser):C2}");
            Console.WriteLine();

            decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"The subtotal for cart 2 is {subTotal:C2}"),
                (products, subTotal) =>
                {
                    if (products.Count > 3)
                    {
                        return subTotal * 0.5M;
                    }
                    else
                    {
                        return subTotal;
                    }
                },
                (message) => Console.WriteLine($"Cart 2 Alert: {message}")
                );

            Console.WriteLine($"The total for cart 2 is {total:C2}");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Please press any key to exit the application...");
            Console.ReadKey();
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");

        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        private static decimal CalculateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.95M;
            }
            else
            {
                return subTotal;
            }

        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Sereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Susu", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Stroberi", Price = 7.51M });
            //cart.Items.Add(new ProductModel { ItemName = "Blueberi", Price = 8.84M });

        }
    }
}
