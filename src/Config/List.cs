using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using ExpandedLiquidContainers.Constructor;
using Vintagestory.API.Common;

namespace ExpandedLiquidContainers.List
{
  [JsonObject]
	public class ExpandedLiquidContainersConfig : ModSystem, IEnumerable<KeyValuePair<string, Part>>
	{
		public static ExpandedLiquidContainersConfig Loaded { get; set; } = new ExpandedLiquidContainersConfig();

		public Part AnvilMold { get; set; } = new Part(true, false, 30);
		public Part Chest { get; set; } = new Part(true, false, 50);
		public Part CookingPot { get; set; } = new Part(true, false, 10);
		public Part Crock { get; set; } = new Part(true, false, 8);
		public Part Crucible { get; set; } = new Part(true, false, 8);
		public Part Flowerpot { get; set; } = new Part(true, false, 10);
		public Part Henbox { get; set; } = new Part(true, false, 8);
		public Part Planter { get; set; } = new Part(true, false, 25);
		public Part StorageVessel { get; set; } = new Part(true, false, 50);
		public Part TroughLarge { get; set; } = new Part(true, false, 40);
		public Part TroughSmall { get; set; } = new Part(true, false, 16);
		public Part WoodenPan { get; set; } = new Part(true, false, 8);

		private static readonly PropertyInfo[] propertyInfos = typeof(ExpandedLiquidContainersConfig).GetProperties()
			.Where(propertyInfo => propertyInfo.PropertyType == typeof(Part)).ToArray();

		public IEnumerator<KeyValuePair<string, Part>> GetEnumerator()
		{
			return propertyInfos.Select(propertyInfo => new KeyValuePair<string, Part>(propertyInfo.Name, (Part)propertyInfo.GetValue(this))).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}