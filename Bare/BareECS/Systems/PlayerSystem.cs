using System;
using System.IO;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace BareECS.Systems
{
	public class PlayerSystem : ISystem
	{
		[Event]
		public void OnPlayerConnect(Player player)
		{
			player.GameText("~w~SA-MP: ~r~Bare Script", 5000, 5);
		}

		[Event]
		public void OnPlayerSpawn(Player player)
		{
			player.Interior = 0;
			player.ToggleClock(true);
		}

		[Event]
		public void OnPlayerDeath(Player player, Player killer, Weapon weapon)
		{

		}

		[Event]
		public void OnPlayerRequestClass(Player player, int classid)
		{
			SetupPlayerForClassSelection(player);
		}

		private void SetupPlayerForClassSelection(Player player)
		{
			player.Interior = 14;
			player.Position = new Vector3(258.4893f, -41.4008f, 1002.0234f);
			player.Angle = 0.0f;
			player.CameraPosition = new Vector3(256.0815f, -43.0475f, 1004.0234);
			player.SetCameraLookAt(new Vector3(258.4893f, -41.4008f, 1002.0234f));
		}

	}
}
