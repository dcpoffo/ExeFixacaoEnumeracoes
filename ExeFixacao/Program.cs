using ExeFixacao.Entities;
using ExeFixacao.Entities.Enums;
using System;
using System.Globalization;

namespace ExeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CLIENT DATA:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("*******************");
            Console.WriteLine("ENTER ORDER DATA: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //instanciando um novo cliente
            Client client = new Client(clientName, email, birthDate);
            //instanciando um novo pedido
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();
            Console.Write("How many itens to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i+1} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
               
                //instanciando um novo produto para o pedito atual
                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                //instanciando um novo item do pedito para o pedito atual
                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            //Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
            //Console.Write("END OF ORDER");
        }
    }
}
