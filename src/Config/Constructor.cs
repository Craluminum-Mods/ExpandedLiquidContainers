namespace ExpandedLiquidContainers.Constructor
{
  public class Part
	{
		public bool Enabled { get; set; }
		public bool MilkingContainer { get; set; }
		public int CapacityLitres { get; set; }
		public int Default { get; set; }

    public Part(bool enabled, bool milkingContainer, int capacityLitres)
    {
			Enabled = enabled;
			MilkingContainer = milkingContainer;
			CapacityLitres = capacityLitres;
			Default = capacityLitres;
    }
	}
}