using System.Collections.Generic;
using Vintagestory.API.Common;
using ExpandedLiquidContainers.Constructor;
using ExpandedLiquidContainers.List;

[assembly: ModInfo("Expanded Liquid Containers",
  Description = "Adds more liquid containers",
  Website = "https://github.com/Craluminum2413/ExpandedLiquidContainers",
  Authors = new[] { "Craluminum2413" })]

namespace ExpandedLiquidContainers
{
  public class Core : ModSystem
	{
    public override void StartPre(ICoreAPI api)
		{
			base.StartPre(api);

			ExpandedLiquidContainersConfig settingsFromDisk;

			try
			{
				settingsFromDisk = api.LoadModConfig<ExpandedLiquidContainersConfig>("ExpandedLiquidContainersConfig.json");
			}
			catch
			{
				settingsFromDisk = null;
			}

			if (settingsFromDisk is null)
			{
				settingsFromDisk = ExpandedLiquidContainersConfig.Loaded;
				api.StoreModConfig<ExpandedLiquidContainersConfig>(ExpandedLiquidContainersConfig.Loaded, "ExpandedLiquidContainersConfig.json");
			}

			foreach (KeyValuePair<string, Part> p in settingsFromDisk)
			{
				api.World.Config.SetBool($"lc{p.Key}Enabled", p.Value.Enabled);
				api.World.Config.SetInt($"lc{p.Key}Litres", p.Value.CapacityLitres);
				api.World.Config.SetBool($"lc{p.Key}Milk", p.Value.MilkingContainer);
			}
		}
	}
}