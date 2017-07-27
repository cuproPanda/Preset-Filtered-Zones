
namespace PresetFilteredZones
{
  public class Designator_RottableZoneAdd : Designator_PresetZoneAdd
  {
    public Designator_RottableZoneAdd()
    {
      zoneTypeToPlace = typeof(Zone_PresetStockpile);
      preset = PresetZoneType.Rottable;
      defaultLabel = Static.GetEnumDescription(preset);
      defaultDesc = Static.RottableZoneDesc;
      icon = Static.TexRottableZone;
      def = Static.DesRottableZone;
    }
  }
}
