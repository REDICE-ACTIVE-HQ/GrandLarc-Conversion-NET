using System;
using SampSharp.Core;


namespace BareNGS
{
	public class Program
	{
		public static void Main(string[] args)
		{
			new GameModeBuilder().RedirectConsoleOutput().Use<Gamemode>().Run();
		}
	}
}
