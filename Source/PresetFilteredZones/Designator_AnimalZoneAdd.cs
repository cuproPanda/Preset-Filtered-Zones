
namespace PresetFilteredZones {

  public class Designator_AnimalZoneAdd : Designator_PresetZoneAdd {

    public Designator_AnimalZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Animal;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.AnimalZoneDesc;
      icon = Static.TexAnimalZone;
      def = Static.DesAnimalZone;
    }
  }
}
