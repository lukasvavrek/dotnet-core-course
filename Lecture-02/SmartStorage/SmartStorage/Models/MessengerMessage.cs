namespace SmartStorage.Models
{
	public class MessengerMessage : IMessage
    {
		public int Key { get; }

		public string Sender { get; }
		public string Receiver { get; }

		public string Content { get; }

        public MessengerMessage(
			int key,
			string sender, 
			string receiver, 
			string content)
        {
			Key = key;
			Sender = sender;
			Receiver = receiver;
			Content = content;
        }
    }
}
