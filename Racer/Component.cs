namespace Racer
{
	using Racer.Contracts.Events;
	using Racer.Events;
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Component
	{
		private static readonly Lazy<Dictionary<Type, List<object>>> LazyEventSubscriptions = new(() => []);

		private static Dictionary<Type, List<object>> EventSubscriptions => LazyEventSubscriptions.Value;

		public void Subscribe<TEvent>(Action<TEvent> action)
			where TEvent : IEvent
		{
			if (!EventSubscriptions.TryGetValue(typeof(TEvent), out var subscriptions))
			{
				subscriptions = [];
				EventSubscriptions.Add(typeof(TEvent), subscriptions);
			}

			subscriptions.Add(new Subscription<TEvent>(this, action));
		}

		public static void Publish<TEvent>(TEvent @event)
			where TEvent : IEvent
		{
			if (EventSubscriptions.TryGetValue(typeof(TEvent), out var subscriptions))
			{
				subscriptions.Cast<Subscription<TEvent>>()
					.ToList()
					.ForEach(x => x.Action.Invoke(@event));
			}
		}
	}
}
