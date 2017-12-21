
namespace PresetFilteredZones
{
  public class Designator_RottableZoneAdd : Designator_PresetZoneAdd
  {
    public Designator_RottableZoneAdd()
    {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Rottable;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.RottableZoneDesc;
      icon = Static.TexRottableZone;
      def = Static.DesRottableZone;
    }
  }
}
