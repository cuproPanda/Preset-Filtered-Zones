
namespace PresetFilteredZones {

  public class Designator_MeatZoneAdd : Designator_PresetZoneAdd {

    public Designator_MeatZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Meat;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.MeatZoneDesc;
      icon = Static.TexMeatZone;
      def = Static.DesMeatZone;
    }
  }
}
