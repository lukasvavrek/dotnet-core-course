using System;
using SmartStorage.Models;
using SmartStorage.Storage;

namespace SmartStorage
{
    class Program
    {
        static void Main(string[] args)
        {
			var storage = new Storage<MessengerMessage>();
			storage.Add(new MessengerMessage(0, "Janko Hrasko", "Snehulienka", "Ahoj"));
			storage.Add(new MessengerMessage(1, "Snehulienka", "Janko Hrasko", "Cau"));
			storage.Add(new MessengerMessage(2, "Gandalf", "Snehulienka", "Ides vonku?"));
			storage.Add(new MessengerMessage(3, "Snehulienka", "Gandalf", "Nie."));
			storage.Add(new MessengerMessage(4, "Gandalf", "Janko Hrasko", "Nechce ist :("));

			foreach (var message in storage.Messages)
			{
				Console.WriteLine($"[{message.Key}] {message.Sender} : {message.Receiver} => {message.Content}");
			}
        }
    }
}
