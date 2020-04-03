using ExeFixacao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExeFixacao.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus orderStatus, Client client)
        {
            Date = date;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem (OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            // para cada ItemPedido (apelidado de item) na lista de ItensPedido
            foreach (OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** ORDER SUMMARY ***");
            sb.AppendLine($"Order moment: {Date.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {OrderStatus}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine();
            sb.AppendLine("Order Itens:");
            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total Price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");
            sb.AppendLine("*** END OF ORDER ***");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
