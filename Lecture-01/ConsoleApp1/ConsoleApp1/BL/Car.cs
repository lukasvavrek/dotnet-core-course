using System;

namespace ConsoleApp1.BL
{
	public class Car : IOpener
	{
		public string Name { get; }

		public Car(string name)
		{
			Name = name;
		}

		public void Open()
		{
			Console.WriteLine($"Opening: {Name}");
		}
	}
}
