using System;
using SampSharp.Core;
using SampSharp.Entities;

namespace BareECS
{
	public class Program
	{
		public static void Main(string[] args)
		{
			new GameModeBuilder().UseEcs<Startup>().Run();
		}
	}
}