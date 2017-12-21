using System.Collections.Generic;

using RimWorld;
using Verse;

namespace PresetFilteredZones
{

  public class Designator_PresetZoneAdd : Designator_ZoneAddStockpile
  {

    protected PresetZoneType presetZoneType;
    protected DesignationDef def;


    //protected override string NewZoneLabel {
    //  get {
    //    return Static.GetEnumDescription(preset);
    //  }
    //}

    
    protected override Zone MakeNewZone()
    {
      Zone_Stockpile zone = base.MakeNewZone() as Zone_Stockpile;
      if (zone != null)
      {
        zone.settings.filter = DefaultFilters.GetFilterFromPreset(presetZoneType);
        zone.color = PresetZoneColorUtility.NewZoneColor(presetZoneType);
      }
      return zone;
    }
  }
}
