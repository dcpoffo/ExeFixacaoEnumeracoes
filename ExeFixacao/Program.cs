using ExeFixacao.Entities;
using ExeFixacao.Entities.Enums;
using System;

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
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            //instanciando um novo cliente
            Client client = new Client(clientName, email, birthDate);
            //instanciando um novo pedido
            Order order = new Order(DateTime.Now, status, client);
        }
    }
}
