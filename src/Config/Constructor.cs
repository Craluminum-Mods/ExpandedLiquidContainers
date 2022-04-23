namespace ExpandedLiquidContainers.Constructor
{
  public class Part
  {
    public bool Enabled { get; set; }
    public bool StoreMeal { get; set; }
    public int CapacityServings { get; set; }
    public int CapacityLitres { get; set; }
    public int Default { get; set; }

    public Part(bool enabled, bool storeMeal, int capacityServings, int capacityLitres)
    {
      Enabled = enabled;
      StoreMeal = storeMeal;
      CapacityServings = capacityServings;
      CapacityLitres = capacityLitres;
      Default = capacityLitres;
    }
  }
}