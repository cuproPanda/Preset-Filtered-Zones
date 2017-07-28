﻿using System.Collections.Generic;
using System.Linq;

using RimWorld;
using Verse;

namespace PresetFilteredZones {

  public static class DefaultFilters {


    public static ThingFilter DefaultFilter_SHTF() {
      ThingFilter filter = new ThingFilter();
      filter.SetAllow(ThingCategoryDefOf.Root, true);
      return filter;
    }


    public static ThingFilter DefaultFilter_MealZone() {
      List<ThingDef> database = DefDatabase<ThingDef>.AllDefsListForReading;
      ThingFilter filter = new ThingFilter();
      filter.SetDisallowAll();

      for (int t = 0; t < database.Count; t++) {
        if (database[t].comps.Any(c => c is CompProperties_Rottable) && database[t].IsIngestible && ((database[t].ingestible.foodType & FoodTypeFlags.Meal) != 0)) {
          filter.SetAllow(database[t], true);
        }
      }
      return filter;
    }


    public static ThingFilter DefaultFilter_MedZone() {
      ThingFilter filter = new ThingFilter();
      filter.SetDisallowAll();

      filter.SetAllow(ThingCategoryDefOf.Medicine, true);
      return filter;
    }


    public static ThingFilter DefaultFilter_MeatZone() {
      List<ThingDef> database = DefDatabase<ThingDef>.AllDefsListForReading;
      ThingFilter filter = new ThingFilter();
      filter.SetDisallowAll();

      for (int t = 0; t < database.Count; t++) {
        if (database[t].IsIngestible && database[t].ingestible.sourceDef != null && database[t].ingestible.sourceDef.race != null && !database[t].ingestible.sourceDef.race.Humanlike && database[t].ingestible.sourceDef.race.FleshType != FleshTypeDefOf.Insectoid) {
          filter.SetAllow(database[t], true);
        }
      }
      filter.SetAllow(ThingCategoryDefOf.Corpses, false);
      return filter;
    }


    public static ThingFilter DefaultFilter_VegZone() {
      List<ThingDef> database = DefDatabase<ThingDef>.AllDefsListForReading;
      ThingFilter filter = new ThingFilter();
      filter.SetDisallowAll();

      for (int t = 0; t < database.Count; t++) {
        if (database[t].comps.Any(c => c is CompProperties_Rottable) && database[t].IsIngestible && (
          ((database[t].ingestible.foodType & FoodTypeFlags.VegetableOrFruit) != 0) ||
          ((database[t].ingestible.foodType & FoodTypeFlags.Seed) != 0))){
          filter.SetAllow(database[t], true);
        }
      }
      return filter;
    }


    public static ThingFilter DefaultFilter_JoyZone() {
      List<ThingDef> database = DefDatabase<ThingDef>.AllDefsListForReading;
      ThingFilter filter = new ThingFilter();
      filter.SetDisallowAll();

      for (int t = 0; t < database.Count; t++) {
        if (database[t].IsIngestible && database[t].ingestible.joyKind != null && database[t].ingestible.joy > 0) {
          filter.SetAllow(database[t], true);
        }
      }
      return filter;
    }


    public static ThingFilter DefaultFilter_AnimalZone() {
      ThingFilter filter = new ThingFilter();
      filter.SetDisallowAll();

      filter.SetAllow(ThingCategoryDefOf.CorpsesAnimal, true);
      filter.SetAllow(ThingCategoryDefOf.CorpsesInsect, false);
      filter.SetAllow(SpecialThingFilterDef.Named("AllowRotten"), false);
      return filter;
    }

    public static ThingFilter DefaultFilter_RottableZone()
    {
      var filter = new ThingFilter();
      filter.SetDisallowAll(null, DefDatabase<SpecialThingFilterDef>.AllDefs);

      DefDatabase<ThingDef>.AllDefs
        .Where(d => d.HasComp(typeof(CompRottable)))
        .ToList()
        .ForEach(d => filter.SetAllow(d, true));
      
      filter.SetAllow(SpecialThingFilterDef.Named("AllowRotten"), false);
      filter.SetAllow(ThingCategoryDefOf.CorpsesHumanlike, false);

      return filter;
    }


    public static ThingFilter DefaultFilter_IndoorZone()
    {
      var filter = new ThingFilter();
      filter.SetDisallowAll(null, DefDatabase<SpecialThingFilterDef>.AllDefs);

      DefDatabase<ThingDef>.AllDefs
        .Where(d => !d.HasComp(typeof(CompRottable)))
        .Where(d => d.GetStatValueAbstract(StatDefOf.DeteriorationRate) > 0f)
        .ToList()
        .ForEach(d => filter.SetAllow(d, true));
      
      return filter;
    }


    public static ThingFilter DefaultFilter_OutdoorZone()
    {
      var filter = new ThingFilter();
      filter.SetDisallowAll(null, DefDatabase<SpecialThingFilterDef>.AllDefs);

      DefDatabase<ThingDef>.AllDefs
        .Where(d => !d.HasComp(typeof(CompRottable)))
        .Where(d => d.GetStatValueAbstract(StatDefOf.DeteriorationRate) == 0f)
        .ToList()
        .ForEach(d => filter.SetAllow(d, true));

      return filter;

    }
  }
}
