
namespace PresetFilteredZones {

  public class Designator_JoyZoneAdd : Designator_PresetZoneAdd {

    public Designator_JoyZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Joy;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.JoyZoneDesc;
      icon = Static.TexJoyZone;
      def = Static.DesJoyZone;
    }
  }
}
