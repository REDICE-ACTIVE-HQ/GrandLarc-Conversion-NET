using System;
using System.IO;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace BareECS.Systems
{
	public class OGamemode : ISystem
	{
		[Event]
		public void OnGameModeInit(IServerService serverService, IWorldService worldService)
		{
			serverService.SetGameModeText("Bare Script NET 8 ECS");
			serverService.ShowPlayerMarkers(PlayerMarkersMode.Global);
			serverService.ShowNameTags(true);
            serverService.SetNameTagDrawDistance(50.51f);

            serverService.AddPlayerClass(265, new Vector3(1958.3783f, 1343.1572f, 15.3746f), 270.1425f, Weapon.M4, 120, Weapon.AK47, 0, Weapon.Unarmed, 0);
            Console.WriteLine("* [WARN] :Gamemode has Loaded");
		}

		[Event]
		public void OnGameModeExit()
		{
			Console.WriteLine("Gamemode has shutdown");
		}
	}
}