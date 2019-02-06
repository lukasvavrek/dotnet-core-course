using System;

namespace ConsoleApp1.BL
{
	public class Door : IOpener
	{
		public void Open()
		{
			Console.WriteLine($"Opened: Door");
		}
	}
}
