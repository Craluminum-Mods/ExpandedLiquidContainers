namespace ExpandedLiquidContainers.Constructor
{
  public class Part
	{
		public bool Enabled { get; set; }
		public int CapacityLitres { get; set; }
		public int Default { get; set; }

    public Part(bool enabled, int capacityLitres)
    {
			Enabled = enabled;
			CapacityLitres = capacityLitres;
			Default = capacityLitres;
    }
	}
}