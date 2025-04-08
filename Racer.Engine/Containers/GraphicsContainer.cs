namespace Racer.Engine.Containers
{
	using Unity;

	public static class GraphicsContainer
	{
		private static UnityContainer Container { get; set; } = new UnityContainer();

		public static void Register<T>(T instance)
		{
			Container.RegisterInstance(instance);
		}

		public static T Resolve<T>()
		{
			return Container.Resolve<T>();
		}
	}
}
