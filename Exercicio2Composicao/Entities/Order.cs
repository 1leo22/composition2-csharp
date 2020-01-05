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

		public const string DATE_FORMAT = "dd/MM/yyyy";

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
			sb.Append("Order moment: ");
			sb.AppendLine(Moment.ToString());
			sb.Append("Order status: ");
			sb.AppendLine(MyProperty.ToString());
			sb.Append("Client: ");
			sb.Append(Client.Name);
			sb.Append(" (");
			sb.Append(Client.BirthDate.ToString(DATE_FORMAT));
			sb.Append(") - ");
			sb.AppendLine(Client.Email);
			sb.AppendLine("Order items: ");
			foreach(OrderItem item in OrderItem) 
			{
				sb.Append(item.Product.Name);
				sb.Append(", Quantity: ");
				sb.Append(item.Quantity);
				sb.Append(", SubTotal: $");
				sb.AppendLine(item.SubTotal().ToString());
			}
			sb.Append("Total Price: $");
			sb.Append(Total());
			return sb.ToString();
		}
	}
}
