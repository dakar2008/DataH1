using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lommeregner
{
  public partial class Main : Form
  {
    List<string> enteries = new List<string>();
    public Main()
    {
      InitializeComponent();
    }

    private void ClickButton(object sender, EventArgs e)
    {
      Button btn = (Button)sender;
      Display.Text = Calculator.ButtonClick(btn.Name, enteries, Display.Text);
      Display.Focus();
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
      if (Display.Text.Length > 0)
      {
        if (Display.Text.Substring(Display.Text.Length - 1) == " ")
        {
          Display.Text = Display.Text.Remove(Display.Text.Length - 2);
        }
        Display.Text = Display.Text.Remove(Display.Text.Length - 1);
      }
      else
      {
        Display.Text = "";
        enteries.Clear();
      }
      Display.Focus();
    }

    private void DeleteAll()
    {
      Display.Clear();
      Display.Focus();
    }

    private void EqualBtn_Click(object sender, EventArgs e)
    {
      string[] numbers = Display.Text.Replace("π", Math.PI.ToString().Replace(",", ".")).Split(' ');
      double result = 0;
      try
      {
        if (numbers.Length > 3)
        {
          for (int i = 0; i < numbers.Length; i++)
          {
            if (numbers[i] == "*")
            {
              if (double.Parse(numbers[i - 1]) == 0 || double.Parse(numbers[i + 1]) == 0)
              {
                numbers = numbers.Where((source, index) => index != (i - 1)).ToArray();
                numbers = numbers.Where((source, index) => index != (i - 1)).ToArray();
                numbers[i - 1] = "0";
              }
              else
              {
                double calc = double.Parse(numbers[i - 1].Replace('.', ',')) * double.Parse(numbers[i + 1].Replace('.', ','));
                numbers = numbers.Where((source, index) => index != (i - 1)).ToArray();
                numbers = numbers.Where((source, index) => index != (i - 1)).ToArray();
                numbers[i - 1] = calc.ToString();

              }
            }
            else if (numbers[i] == "/")
            {
              if (double.Parse(numbers[i - 1]) == 0 || double.Parse(numbers[i + 1]) == 0)
              {
                History.AppendText(Display.Text + "\n");
                History.AppendText("Result: Der kan ikke divideres med 0\n\n");
                return;
              }

              double calc = double.Parse(numbers[i - 1].Replace('.', ',')) / double.Parse(numbers[i + 1].Replace('.', ','));
              numbers = numbers.Where((source, index) => index != (i - 1)).ToArray();
              numbers = numbers.Where((source, index) => index != (i - 1)).ToArray();
              numbers[i - 1] = calc.ToString();

            }
          }
        }

        result = double.Parse(numbers[0].Replace('.', ','));

        for (int i = 1; i < numbers.Length; i++)
        {
          if (numbers[i] == "+")
          {
            result += double.Parse(numbers[i + 1].Replace('.', ','));
          }
          else if (numbers[i] == "-")
          {
            result -= double.Parse(numbers[i + 1].Replace('.', ','));
          }
          else if (numbers[i] == "*")
          {
            if (double.Parse(numbers[i - 1]) == 0 || double.Parse(numbers[i + 1]) == 0)
            {
              History.AppendText(Display.Text + "\n");
              History.AppendText("Result: 0\n\n");
              Display.Text = "0";
              return;
            }
            result *= double.Parse(numbers[i + 1].Replace('.', ','));
          }
          else if (numbers[i] == "/")
          {
            if (double.Parse(numbers[i - 1]) == 0 || double.Parse(numbers[i + 1]) == 0)
            {
              History.AppendText(Display.Text + "\n");
              History.AppendText("Result: Der kan ikke divideres med 0\n\n");
              return;
            }
            result /= double.Parse(numbers[i + 1].Replace('.', ','));
          }
        }
      }
      catch (Exception ex)
      {
        if (ex is InvalidCastException || ex is System.FormatException)
        {
          History.AppendText(Display.Text + "\n");
          History.AppendText("Result: Fejl i regnestykket\n\n");
          return;
        }

        throw;
      }

      if (Display.Text != result.ToString())
      {
        History.AppendText(Display.Text + "\n");
        Display.Text = result.ToString();
        History.AppendText($"Result: {Display.Text}\n\n");
      }
      else
      {
        Display.Text = result.ToString();
      }
      Display.Focus();
    }

    private void Display_KeyDown(object sender, KeyEventArgs e)
    {
      e.Handled = false;

      if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
      {
        Num_0.PerformClick();
      }
      else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
      {
        Num_1.PerformClick();
      }
      else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
      {
        Num_2.PerformClick();
      }
      else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
      {
        Num_3.PerformClick();
      }
      else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
      {
        Num_3.PerformClick();
      }
      else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
      {
        Num_4.PerformClick();
      }
      else if (e.KeyCode == Keys.D5 & e.Control || e.KeyCode == Keys.NumPad5 && e.Control)
      {
        PiBtn.PerformClick();
      }
      else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
      {
        Num_5.PerformClick();
      }
      else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
      {
        Num_6.PerformClick();
      }
      else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
      {
        Num_7.PerformClick();
      }
      else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
      {
        Num_8.PerformClick();
      }
      else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
      {
        Num_9.PerformClick();
      }
      else if (e.KeyCode == Keys.Back && e.Control || e.KeyCode == Keys.Delete && e.Control)
      {
        DeleteAll();
      }
      else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
      {
        Delete_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Divide)
      {
        Divide_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Multiply)
      {
        Multiply_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Subtract)
      {
        Subtract_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Add)
      {
        Add_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
      {
        Decimal_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Enter)
      {
        EqualBtn.PerformClick();
      }
      else
      {
        e.Handled = true;
      }
    }

    private void History_KeyDown(object sender, KeyEventArgs e)
    {
      e.Handled = false;

      if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
      {
        Num_0.PerformClick();
      }
      else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
      {

        Num_1.PerformClick();
      }
      else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
      {

        Num_2.PerformClick();
      }
      else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
      {

        Num_3.PerformClick();
      }
      else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
      {

        Num_3.PerformClick();
      }
      else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
      {

        Num_4.PerformClick();
      }
      else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
      {

        Num_5.PerformClick();
      }
      else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
      {

        Num_6.PerformClick();
      }
      else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
      {

        Num_7.PerformClick();
      }
      else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
      {
        Num_8.PerformClick();
      }
      else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
      {
        Num_9.PerformClick();
      }
      else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
      {
        Delete_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Divide)
      {
        Divide_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Multiply)
      {
        Multiply_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Subtract)
      {
        Subtract_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Add)
      {
        Add_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
      {
        Decimal_Btn.PerformClick();
      }
      else if (e.KeyCode == Keys.Enter)
      {
        EqualBtn.PerformClick();
      }
      else
      {
        e.Handled = true;
      }
    }

    private void PiBtn_Click(object sender, EventArgs e)
    {
      Display.Text = Display.Text + "π";
      Display.Focus();
    }

    private void Display_Enter(object sender, EventArgs e)
    {
      Display.Select(0, 0);
    }

    private void ClearHistoryBtn_Click(object sender, EventArgs e)
    {
      History.Clear();
    }

    private void SquareRootBtn_Click(object sender, EventArgs e)
    {
      if (Display.Text.Length > 0)
      {
        History.Text = History.Text + "√ (" + Display.Text + ")\n";
        Display.Text = Math.Sqrt(Convert.ToDouble(Display.Text)).ToString();
      }
    }
  }
}