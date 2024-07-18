using System;
using System.IO;
using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Display;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.SAMP.Commands;
using SampSharp.GameMode.World;


namespace BareNGS
{
	public class Gamemode : BaseMode
	{
		protected override void OnInitialized(EventArgs e)
		{
			SetGameModeText("Bare Script .NET 8 (4)");
			ShowPlayerMarkers(PlayerMarkersMode.Global);
			ShowNameTags(true);

			AddPlayerClass(265, new Vector3(1958.3783f, 1343.1572f, 15.3746f), 270.1425f, Weapon.M4, 120, Weapon.Unarmed, 0, Weapon.Unarmed, 0);
			Console.WriteLine("[WARN] Server Is Working");
		}

	}
}