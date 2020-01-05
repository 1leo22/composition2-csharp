using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio2Composicao.Entities
{
	class OrderItem
	{
		public int Quantity { get; set; }
		public double Price { get; set; }
		public Product Product { get; set; }


		public OrderItem(int quantity, double price, Product product)
		{
			Quantity = quantity;
			Price = price;
			Product = product;
		}

		public double SubTotal() 
		{
			double subtotal = Quantity * Price;

			return subtotal;
		}

		public override string ToString()
		{
			string msg = $"{Product.Name}, ${Product.Price}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";

			return msg;
		}
	}
}
