namespace SimpleGraphicsEngine.Polygon3D
{
	using System;
	using IROM.Core;
	using IROM.Util;

	public class Polygon3DCore : Core
	{
		public static void Main()
		{
			try
			{
				new Polygon3DCore().Start();
			}catch (Exception ex)
 			{
				Console.WriteLine(ex);
			}
		}

		public Polygon3DCore() : base("Polygon3DCore")
		{
			
		}

		protected override void Init()
		{
			//close on window X
			WindowObj.OnClose += ((sender, args) => Running = false);
		}

		protected override void Tick()
		{
			
		}

		protected override void Render(Image image)
		{
			
		}
	}
}
