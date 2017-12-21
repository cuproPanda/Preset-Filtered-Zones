﻿using System.Collections.Generic;

using UnityEngine;
using Verse;

namespace PresetFilteredZones
{

  public enum PresetZoneType
  {
    None,
    [Description(Static.MealZoneLabel)]
    Meal,
    [Description(Static.MeatZoneLabel)]
    Meat,
    [Description(Static.VegZoneLabel)]
    Veg,
    [Description(Static.MedZoneLabel)]
    Med,
    [Description(Static.JoyZoneLabel)]
    Joy,
    [Description(Static.AnimalZoneLabel)]
    Animal,
    [Description(Static.RottableZoneLabel)]
    Rottable,
    [Description(Static.IndoorZoneLabel)]
    Indoor,
    [Description(Static.OutdoorZoneLabel)]
    Outdoor
  }



  [StaticConstructorOnStartup]
  public static class PresetZoneColorUtility
  {

    private const float ZoneOpacity = 0.15f;
    private static List<Color> mealZonePalette;
    private static List<Color> medZonePalette;
    private static List<Color> meatZonePalette;
    private static List<Color> vegZonePalette;
    private static List<Color> joyZonePalette;
    private static List<Color> animalZonePalette;
    private static List<Color> rottableZonePalette;
    private static List<Color> indoorZonePalette;
    private static List<Color> outdoorZonePalette;


    static PresetZoneColorUtility()
    {
      PaintMealZone();
      PaintMedZone();
      PaintMeatZone();
      PaintVegZone();
      PaintJoyZone();
      PaintAnimalZone();
      PaintRottableZone();
      PaintIndoorZone();
      PaintOutdoorZone();
    }


    public static Color NewZoneColor(PresetZoneType type)
    {
      if (type == PresetZoneType.Meal)
      {
        return mealZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Med)
      {
        return medZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Meat)
      {
        return meatZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Veg)
      {
        return vegZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Joy)
      {
        return joyZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Animal)
      {
        return animalZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Rottable)
      {
        return rottableZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Indoor)
      {
        return indoorZonePalette.RandomElement();
      }
      if (type == PresetZoneType.Outdoor)
      {
        return outdoorZonePalette.RandomElement();
      }

      return ColorLibrary.Grey;
    }


    private static List<Color> Dilute(List<Color> palette)
    {
      List<Color> dilutedColors = new List<Color>();
      foreach (Color color in palette)
      {
        Color c = new Color(color.r, color.g, color.b, ZoneOpacity);
        dilutedColors.Add(c);
      }
      return dilutedColors;
    }


    private static void PaintMealZone()
    {
      mealZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Purple,
        ColorLibrary.Violet,
        ColorLibrary.DeepPurple,
        ColorLibrary.RoyalPurple,
        ColorLibrary.Plum,
        ColorLibrary.BrightPurple,
        ColorLibrary.Indigo,
        ColorLibrary.Lilac,
        ColorLibrary.DarkPurple,
        ColorLibrary.Lavender
      });
    }


    private static void PaintMedZone()
    {
      medZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Blue,
        ColorLibrary.BabyBlue,
        ColorLibrary.Navy,
        ColorLibrary.Aquamarine,
        ColorLibrary.BrightBlue,
        ColorLibrary.NavyBlue,
        ColorLibrary.RoyalBlue,
        ColorLibrary.Aqua,
        ColorLibrary.DarkBlue
      });
    }


    private static void PaintMeatZone()
    {
      meatZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Red,
        ColorLibrary.Magenta,
        ColorLibrary.Burgundy,
        ColorLibrary.BrickRed,
        ColorLibrary.DarkRed,
        ColorLibrary.Rose,
        ColorLibrary.DarkPink,
        ColorLibrary.HotPink,
        ColorLibrary.Salmon,
        ColorLibrary.Maroon,
        ColorLibrary.Mauve
      });
    }


    private static void PaintVegZone()
    {
      vegZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Green,
        ColorLibrary.PastelGreen,
        ColorLibrary.PeaGreen,
        ColorLibrary.PukeGreen,
        ColorLibrary.GrassGreen,
        ColorLibrary.OliveGreen,
        ColorLibrary.ForestGreen,
        ColorLibrary.DarkGreen
      });
    }


    private static void PaintJoyZone()
    {
      joyZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Orange,
        ColorLibrary.Yellow,
        ColorLibrary.DarkOrange,
        ColorLibrary.Sand,
        ColorLibrary.LightOrange,
        ColorLibrary.Gold,
        ColorLibrary.Mustard
      });
    }


    private static void PaintAnimalZone()
    {
      animalZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Brown,
        ColorLibrary.Leather,
        ColorLibrary.DarkBrown
      });
    }


    private static void PaintRottableZone()
    {
      rottableZonePalette = Dilute(new List<Color>() {
        ColorLibrary.LightBlue,
        ColorLibrary.Cyan,
        ColorLibrary.Blue
      });
    }


    private static void PaintIndoorZone()
    {
      indoorZonePalette = Dilute(new List<Color>() {
        ColorLibrary.Teal,
        ColorLibrary.DarkTeal,
        ColorLibrary.Olive,
        ColorLibrary.Maroon
      });
    }


    private static void PaintOutdoorZone()
    {
      outdoorZonePalette = new List<Color>();
      for (int c = 0; c < mealZonePalette.Count; c++)
      {
        float v = mealZonePalette[c].grayscale;
        outdoorZonePalette.Add(new Color(v, v, v, ZoneOpacity));
      }
    }
  }
}