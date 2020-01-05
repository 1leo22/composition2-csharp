using System;
using System.Collections.Generic;
using System.Text;
using Exercicio2Composicao.Entities.Enums;
using Exercicio2Composicao.Entities;

namespace Exercicio2Composicao.Entities
{
	class Order
	{
		public DateTime Moment { get; set; }
		public OrderStatus MyProperty { get; set; }
		public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
		public Client Client { get; set; }

		public Order(DateTime moment, OrderStatus myProperty, Client client)
		{
			Moment = moment;
			MyProperty = myProperty;
			Client = client;
		}

		public void AddItem(OrderItem item) 
		{
			OrderItem.Add(item);
		}
		public void RemoveItem(OrderItem item) 
		{
			OrderItem.Remove(item);
		}

		public double Total() 
		{
			double total = 0.0;
			foreach(OrderItem item in OrderItem) 
			{
				total += item.SubTotal();
			}

			return total;
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("ORDER SUMARY: ");
			sb.AppendLine("Order moment: " + Moment.ToString());
			sb.AppendLine("Order status: " + MyProperty.ToString());
			sb.AppendLine("Client: " + Client);
			sb.AppendLine("Order items: ");
			foreach(OrderItem item in OrderItem) 
			{
				sb.AppendLine(item.ToString());
			}
			sb.Append("Total Price: $");
			sb.Append(Total());
			return sb.ToString();
		}
	}
}
