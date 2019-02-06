using System.Collections.Generic;
using ConsoleApp1.BL;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var openers = new List<IOpener>();
			openers.Add(new Car("Fabia"));	
			openers.Add(new Door());	
			openers.Add(new Car("Octavia"));

			foreach (var car in openers)
			{
				car.Open();
			}
		}
	}
}
