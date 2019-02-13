using System.Linq;
using System.Collections.Generic;
using SmartStorage.Models;

namespace SmartStorage.Storage
{
	public class Storage<T> : IStorage<T> where T : class, IMessage
	{
		public IList<T> Messages => _messages;
		private readonly List<T> _messages;

		public Storage()
		{
			_messages = new List<T>();
		}

		public void Add(T item)
		{
			if (!_messages.Any((message) => message.Key == item.Key))
			{
				_messages.Add(item);
			}
		}

		public void Delete(int key)
		{
			var toDelete = _messages
				.FirstOrDefault((message) => message.Key == key);

			if (toDelete != null)
			{
				_messages.Remove(toDelete);
			}
		}
	}
}
