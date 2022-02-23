using System;
using System.Globalization;
using TreiningForCompositionAndEnums.Entities;
using TreiningForCompositionAndEnums.Entities.Enums;

namespace TreiningForCompositionAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("Email: ");
            string mailClient = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(nameClient, mailClient, birthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order?");
            int HowManyOrders = int.Parse(Console.ReadLine());

            for(int i = 0; i < HowManyOrders; i++)
            {
                Console.WriteLine($"Enter #{HowManyOrders} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, priceProduct);

                Console.Write("Quantity: ");
                int quantityProduc = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantityProduc, priceProduct, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
