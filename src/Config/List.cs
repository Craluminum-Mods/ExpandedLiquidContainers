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

    public Part StationaryBasket { get; set; } = new Part(true, true, 10, 10);
    public Part WateringCan { get; set; } = new Part(true, true, 20, 20);
    public Part Chest { get; set; } = new Part(true, true, 50, 50);
    public Part CookingPot { get; set; } = new Part(true, true, 6, 6);
    public Part Crock { get; set; } = new Part(true, true, 4, 4);
    public Part Crucible { get; set; } = new Part(true, true, 4, 4);
    public Part Flowerpot { get; set; } = new Part(true, true, 10, 10);
    public Part Henbox { get; set; } = new Part(true, true, 8, 8);
    public Part MoldAnvil { get; set; } = new Part(true, true, 36, 36);
    public Part MoldAxe { get; set; } = new Part(true, true, 8, 8);
    public Part MoldBullets { get; set; } = new Part(false, true, 8, 8);
    public Part MoldHammer { get; set; } = new Part(true, true, 8, 8);
    public Part MoldHelveHammer { get; set; } = new Part(true, true, 16, 16);
    public Part MoldHoe { get; set; } = new Part(true, true, 8, 8);
    public Part MoldIngot { get; set; } = new Part(true, true, 8, 8);
    public Part MoldLamellae { get; set; } = new Part(true, true, 8, 8);
    public Part MoldLongblade { get; set; } = new Part(true, true, 8, 8);
    public Part MoldPickaxe { get; set; } = new Part(true, true, 8, 8);
    public Part MoldProPick { get; set; } = new Part(true, true, 8, 8);
    public Part MoldShovel { get; set; } = new Part(true, true, 8, 8);
    public Part Planter { get; set; } = new Part(true, true, 25, 25);
    public Part StorageVessel { get; set; } = new Part(true, true, 50, 50);
    public Part TroughLarge { get; set; } = new Part(true, true, 40, 40);
    public Part TroughSmall { get; set; } = new Part(true, true, 16, 16);
    public Part WoodenPan { get; set; } = new Part(true, true, 8, 8);

    private static readonly PropertyInfo[] propertyInfos = typeof(ExpandedLiquidContainersConfig).GetProperties()
      .Where(propertyInfo => propertyInfo.PropertyType == typeof(Part)).ToArray();

    public IEnumerator<KeyValuePair<string, Part>> GetEnumerator()
    {
      return propertyInfos.Select(propertyInfo => new KeyValuePair<string, Part>(propertyInfo.Name, (Part)propertyInfo.GetValue(this))).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}