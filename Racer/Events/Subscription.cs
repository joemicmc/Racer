namespace Racer.Events
{
	using System;

	public class Subscription<TEvent>(object owner, Action<TEvent> action)
		: Subscription(owner)
	{
		public Action<TEvent> Action { get; private set; } = action;
	}

	public class Subscription(object owner)
	{
		public object Owner { get; private set; } = owner;
	}
}
