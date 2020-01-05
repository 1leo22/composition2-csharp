using System;
using Exercicio2Composicao.Entities.Enums;
using System.Globalization;
using Exercicio2Composicao.Entities;

namespace Exercicio2Composicao
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter cliente data: ");
			Console.Write("Name: ");
			string name = Console.ReadLine();
	
			Console.Write("Email: ");
			string email = Console.ReadLine();
			
			Console.Write("Birth date (DD/MM/YYYY): ");
			DateTime birth = DateTime.Parse(Console.ReadLine());

			Console.WriteLine("Enter order data: ");
			Console.Write("Status: ");
			OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

			Console.Write("How many items to this order? ");
			int numberItem = int.Parse(Console.ReadLine());

			DateTime moment = DateTime.Now;
			Client client = new Client(name, email, birth);
			Order order = new Order(moment, orderStatus, client);

			for(int i = 1; i <= numberItem; i++) 
			{
				Console.WriteLine($"Enter #{i} item data: ");
				Console.Write("Product name: ");
				string productName = Console.ReadLine();
				Console.Write("Product price: ");
				double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.Write("Quantity: ");
				int quantity = int.Parse(Console.ReadLine());
				Console.WriteLine();
				Product produtc = new Product(productName, price);
				OrderItem item = new OrderItem(quantity, price, produtc);
				order.AddItem(item);
			}

			Console.WriteLine(order);
		}
	}
}
