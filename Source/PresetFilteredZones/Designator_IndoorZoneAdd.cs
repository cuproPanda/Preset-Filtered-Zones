
namespace PresetFilteredZones
{
  public class Designator_IndoorZoneAdd : Designator_PresetZoneAdd
  {
    public Designator_IndoorZoneAdd()
    {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Indoor;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.IndoorZoneDesc;
      icon = Static.TexIndoorZone;
      def = Static.DesIndoorZone;
    }
  }
}
