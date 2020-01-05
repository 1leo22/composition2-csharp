using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2Composicao.Entities.Enums
{
	class Client
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }

		public Client(string name, DateTime birthDate) : this (name, null, birthDate)
		{

		}

		public Client(string name, string email, DateTime birthDate)
		{
			Name = name;
			Email = email;
			BirthDate = birthDate;
		}
	}
}
