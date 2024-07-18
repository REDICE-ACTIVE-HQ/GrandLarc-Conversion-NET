using System;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.World;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.SAMP.Commands;

namespace BareNGS
{
	[PooledType]
	public partial class Player : BasePlayer 
	{
		public override void OnConnected(EventArgs e)
		{
		  	base.OnConnected(e);
		  	GameText("~w~SA-MP: ~r~Bare Script", 5000, 5);
		  	Console.WriteLine("[WARN] Connected Declared");
		}

		[Command("yadayada")]
		private void YadaMethod()
		{
			SendClientMessage("{00FF00} Command Has Been Executed (YadaYada)");
		}

		public override void OnDeath(DeathEventArgs e)
		{
			base.OnDeath(e);
			Console.WriteLine("[WARN] Death Declared");
		}

		public override void OnSpawned(SpawnEventArgs e)
		{
			base.OnSpawned(e);
			Interior= 0;
			ToggleClock(true);
			Console.WriteLine("[WARN] Spawned Declared");
			Console.WriteLine("[WARNED] Spawn Class Declared");
		}

		public override void OnRequestClass(RequestClassEventArgs e)
		{
			base.OnRequestClass(e);
			SetupPlayerForClassSelection();
			Console.WriteLine("[WARN] Request Declared");
		}

		private void SetupPlayerForClassSelection()
		{
			Interior = 14;
			Position = new Vector3(258.4893f, -41.4008f, 1002.0234f);
			Angle = 270.01f;
			CameraPosition = new Vector3(256.0815f, -43.0475f, 1004.0234f);
			SetCameraLookAt(new Vector3(258.4893f, -41.4008f, 1002.0234f));
			Console.WriteLine("[WARN] Selection Declared");
		}
  
	}
}