
namespace PresetFilteredZones {

  public class Designator_MedZoneAdd : Designator_PresetZoneAdd {

    public Designator_MedZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Med;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.MedZoneDesc;
      icon = Static.TexMedZone;
      def = Static.DesMedZone;
    }
  }
}
