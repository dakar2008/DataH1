using System.Collections.Generic;

namespace lommeregner
{
  public static class Calculator
  {
    public static string ButtonClick(string buttonName, List<string> enteries, string input)
    {
      string[] splitButtonName = buttonName.Split("_");
      if (splitButtonName.Length > 0)
      {
        if (splitButtonName[0] == "Num")
        {
          if (splitButtonName[1].Length == 1)
          {
            enteries.Add(splitButtonName[1]);
            input += splitButtonName[1];
          }
        }
        else
        {
          switch (splitButtonName[0])
          {
            case "Decimal":
              enteries.Add(".");
              input += ".";
              break;
            case "Add":
              enteries.Add("+");
              input += " + ";
              break;
            case "Subtract":
              enteries.Add("-");
              input += " - ";
              break;
            case "Multiply":
              enteries.Add("*");
              input += " * ";
              break;
            case "Divide":
              enteries.Add("/");
              input += " / ";
              break;
          }
        }
      }
      return input;
    }
  }
}