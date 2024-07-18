//using GrandLarceny.Repositories;
//using GrandLarceny.Services;
using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace BareECS
{
	public class Startup : IStartup
	{
		public void Configure(IServiceCollection services)
		{
			services.AddSystemsInAssembly();
		}

		public void Configure(IEcsBuilder builder)
		{
			builder.EnableSampEvents().EnablePlayerCommands();
		}
	}
}