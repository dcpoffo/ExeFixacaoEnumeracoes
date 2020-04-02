using ExeFixacao.Entities.Enums;
using System;
using System.Collections.Generic;
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
            // fazer construtor do ToString
            // para apresentar o sumario do pedido

            return sb.ToString();
        }
    }
}
