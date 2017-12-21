
namespace PresetFilteredZones {

  public class Designator_VegZoneAdd : Designator_PresetZoneAdd {

    public Designator_VegZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Veg;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.VegZoneDesc;
      icon = Static.TexVegZone;
      def = Static.DesVegZone;
    }
  }
}
