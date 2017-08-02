
namespace PresetFilteredZones {

  public class Designator_MealZoneAdd : Designator_PresetZoneAdd {

    public Designator_MealZoneAdd() {
      zoneTypeToPlace = typeof(RimWorld.Zone_Stockpile);
      presetZoneType = PresetZoneType.Meal;
      defaultLabel = Static.GetEnumDescription(presetZoneType);
      defaultDesc = Static.MealZoneDesc;
      icon = Static.TexMealZone;
      def = Static.DesMealZone;
    }
  }
}
