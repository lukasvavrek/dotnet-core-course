using System.Collections.Generic;
using SmartStorage.Models;

namespace SmartStorage.Storage
{
	public interface IStorage<T> where T : class, IMessage
    {
		IList<T> Messages { get; }
		void Add(T item);
		void Delete(int key);
    }
}
