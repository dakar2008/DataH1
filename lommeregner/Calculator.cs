using System;
using System.Collections.Generic;
using System.Globalization;

namespace lommeregner
{
  public class Calculator
  {
    public Calculator()
    {
    }

    private static readonly CultureInfo provider = CultureInfo.CreateSpecificCulture("da-DK");

    private List<string> tokens = new() { "0" };
    private List<string> Tokens { get => tokens; }

    public string[] History { get; set; } = Array.Empty<string>();

    private string currentNumberString = "";
    public string CurrentNumberString
    {
      get => currentNumberString != "" ? currentNumberString : "0";
      private set => currentNumberString = value;
    }
    private bool IsEnteringNumeric { get; set; } = true;

    void UpdateNumberInputToken()
    {
      if (IsEnteringNumeric)
        Tokens[^1] = currentNumberString;
      else
        Tokens.Add(currentNumberString);
      History = Tokens.ToArray();
      IsEnteringNumeric = true;
    }
    public void InputNumeric(char keyChar)
    {
      if (keyChar != '0' || currentNumberString.Length > 0)
        currentNumberString += keyChar;
      UpdateNumberInputToken();
    }
    public void InputPI()
    {
      currentNumberString = Math.PI.ToString(provider);
      UpdateNumberInputToken();
    }

    public void InputDecimalPoint()
    {
      if (currentNumberString.Length == 0)
        currentNumberString += '0';
      if (!currentNumberString.Contains(','))
      {
        currentNumberString += ',';
      }
      UpdateNumberInputToken();
    }


    public void InputOperator(char keyChar)
    {
      if (keyChar == 'X')
        keyChar = '*';
      if (IsEnteringNumeric)
        AppendToken(keyChar);
      else
        ReplaceLastToken(keyChar);
      IsEnteringNumeric = false;
      CurrentNumberString = "";
    }

    //private bool LastTokenIsAnOperator() => "+-*/".Contains(Tokens[^1]);
    private void ReplaceLastToken(char keyChar)
    {
      Tokens[^1] = keyChar.ToString();
      History = Tokens.ToArray();
    }

    private void AppendToken(char keyChar)
    {
      Tokens.Add(keyChar.ToString());
      History = Tokens.ToArray();
    }

    private double Parse(string input)
    {
      var numberStyle = NumberStyles.Float | NumberStyles.AllowThousands | NumberStyles.AllowExponent;
      return double.Parse(input, numberStyle, provider);
    }
    public void Calculate()
    {
      // first handle mult and div
      for (var i = 1; i < tokens.Count - 1; i += 2)
      {
        var @operator = tokens[i][0];
        if ("*/".Contains(@operator))
        {
          var a = Parse(tokens[i - 1]);
          var b = Parse(tokens[i + 1]);
          if (@operator == '*')
            tokens[i - 1] = (a * b).ToString();
          else
            tokens[i - 1] = (a / b).ToString();
          tokens.RemoveRange(i, 2);
          i -= 2;
        }
      }
      for (var i = 1; i < tokens.Count - 1; i += 2)
      {
        var @operator = tokens[i][0];
        var a = Parse(tokens[i - 1]);
        var b = Parse(tokens[i + 1]);
        if (@operator == '+')
          tokens[i - 1] = (a + b).ToString();
        else
          tokens[i - 1] = (a - b).ToString();
        tokens.RemoveRange(i, 2);
        i -= 2;
      }
      currentNumberString = tokens[0];
    }

    public void CalculateSquareRoot()
    {
      Calculate();
      currentNumberString = Math.Sqrt(Parse(currentNumberString)).ToString(provider);
      tokens[0] = currentNumberString;
    }
  }
}