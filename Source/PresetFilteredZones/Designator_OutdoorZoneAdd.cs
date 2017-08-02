
namespace PresetFilteredZones {

  public class Designator_OutdoorZoneAdd : Designator_PresetZoneAdd {

    public Designator_OutdoorZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Outdoor;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.OutdoorZoneDesc;
      icon = Static.TexOutdoorZone;
      def = Static.DesOutdoorZone;
    }
  }
}
