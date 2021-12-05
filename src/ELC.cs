using Vintagestory.API.Common;

[assembly: ModInfo( "Expanded Liquid Containers", Version = "1.0.0",
	Description = "Adds more liquid containers",
		IconPath = "modicon.png",
		Website	= "https://github.com/Craluminum2413/ExpandedLiquidContainers",
		Authors	= new []{ "Craluminum2413" } )]

namespace ExpandedLiquidContainers
{
	public class ExpandedLiquidContainers : ModSystem
	{
		public override void StartPre(ICoreAPI api)
		{
			base.StartPre(api);

			try
			{
				ExpandedLiquidContainersConfig FromDisk;
				if ((FromDisk = api.LoadModConfig<ExpandedLiquidContainersConfig>("ExpandedLiquidContainersConfig.json")) == null)
				{
					api.StoreModConfig<ExpandedLiquidContainersConfig>(ExpandedLiquidContainersConfig.Loaded, "ExpandedLiquidContainersConfig.json");
				}
				else ExpandedLiquidContainersConfig.Loaded = FromDisk;
			}
			catch
			{
				api.StoreModConfig<ExpandedLiquidContainersConfig>(ExpandedLiquidContainersConfig.Loaded, "ExpandedLiquidContainersConfig.json");
			}
			
			api.World.Config.SetBool("LC_cookingpot_milking", ExpandedLiquidContainersConfig.Loaded.cookingPot_MilkingContainer);
			api.World.Config.SetBool("LC_cookingpot_enabled", ExpandedLiquidContainersConfig.Loaded.cookingPot_Enabled);
			api.World.Config.SetBool("LC_crock_milking", ExpandedLiquidContainersConfig.Loaded.crock_MilkingContainer);
			api.World.Config.SetBool("LC_crock_enabled", ExpandedLiquidContainersConfig.Loaded.crock_Enabled);
			api.World.Config.SetBool("LC_crucible_milking", ExpandedLiquidContainersConfig.Loaded.crucible_MilkingContainer);
			api.World.Config.SetBool("LC_crucible_enabled", ExpandedLiquidContainersConfig.Loaded.crucible_Enabled);
			api.World.Config.SetBool("LC_flowerpot_milking", ExpandedLiquidContainersConfig.Loaded.flowerPot_MilkingContainer);
			api.World.Config.SetBool("LC_flowerpot_enabled", ExpandedLiquidContainersConfig.Loaded.flowerPot_Enabled);
			api.World.Config.SetBool("LC_planter_milking", ExpandedLiquidContainersConfig.Loaded.planter_MilkingContainer);
			api.World.Config.SetBool("LC_planter_enabled", ExpandedLiquidContainersConfig.Loaded.planter_Enabled);
			api.World.Config.SetBool("LC_storagevessel_milking", ExpandedLiquidContainersConfig.Loaded.storageVessel_MilkingContainer);
			api.World.Config.SetBool("LC_storagevessel_enabled", ExpandedLiquidContainersConfig.Loaded.storageVessel_Enabled);
			api.World.Config.SetInt("LC_cookingpot_capacityLitres", ExpandedLiquidContainersConfig.Loaded.cookingPot_capacityLitres);
			api.World.Config.SetInt("LC_crock_capacityLitres", ExpandedLiquidContainersConfig.Loaded.crock_capacityLitres);
			api.World.Config.SetInt("LC_crucible_capacityLitres", ExpandedLiquidContainersConfig.Loaded.crucible_capacityLitres);
			api.World.Config.SetInt("LC_flowerpot_capacityLitres", ExpandedLiquidContainersConfig.Loaded.flowerPot_capacityLitres);
			api.World.Config.SetInt("LC_planter_capacityLitres", ExpandedLiquidContainersConfig.Loaded.planter_capacityLitres);
			api.World.Config.SetInt("LC_storagevessel_capacityLitres", ExpandedLiquidContainersConfig.Loaded.storageVessel_capacityLitres);
		}

		public class ExpandedLiquidContainersConfig
		{
			public static ExpandedLiquidContainersConfig Loaded { get; set; } = new ExpandedLiquidContainersConfig();
			public bool cookingPot_MilkingContainer { get; set; } = false;
			public bool cookingPot_Enabled { get; set; } = true;
			public bool crock_MilkingContainer { get; set; } = false;
			public bool crock_Enabled { get; set; } = true;
			public bool crucible_MilkingContainer { get; set; } = false;
			public bool crucible_Enabled { get; set; } = true;
			public bool flowerPot_MilkingContainer { get; set; } = false;
			public bool flowerPot_Enabled { get; set; } = true;
			public bool planter_MilkingContainer { get; set; } = false;
			public bool planter_Enabled { get; set; } = true;
			public bool storageVessel_MilkingContainer { get; set; } = false;
			public bool storageVessel_Enabled { get; set; } = true;
			public int cookingPot_capacityLitres { get; set; } = 10;
			public int crock_capacityLitres { get; set; } = 8;
			public int crucible_capacityLitres { get; set; } = 8;
			public int flowerPot_capacityLitres { get; set; } = 10;
			public int planter_capacityLitres { get; set; } = 25;
			public int storageVessel_capacityLitres { get; set; } = 50;
		}
	}
}