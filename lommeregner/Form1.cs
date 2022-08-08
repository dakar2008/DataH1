using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lommeregner
{
  public partial class Main : Form
  {
    private Calculator Calc { get; set; } = new();
    public Main()
    {
      InitializeComponent();

      // Form.KeyPreview must be set to true for event handler on form level to be called.
      KeyPreview = true;
    }

    // Detect all numeric characters at the form level and consume 1,4, and 7.
    // Form.KeyPreview must be set to true for this event handler to be called.
    void Main_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
        Calc.InputNumeric(e.KeyChar);
        Display.Text = Calc.CurrentNumberString;
      }
      else
      {
        switch (e.KeyChar)
        {
          case ',':
          case '.':
            e.Handled = true;
            Calc.InputDecimalPoint();
            Display.Text = Calc.CurrentNumberString;
            break;
          case '+':
          case '-':
          case '*':
          case '/':
            Calc.InputOperator(e.KeyChar);
            break;
          case (char)Keys.Return:
            e.Handled = true;
            Calc.Calculate();
            Display.Text = Calc.CurrentNumberString;
            History.Text = string.Join("\n", Calc.History);
            break;
          default:
            break;
        }
      }

      History.Text = string.Join("\n", Calc.History);
    }

    private void Num_Click(object sender, EventArgs e)
    {
      Calc.InputNumeric(((Button)sender).Text[0]);
      Display.Text = Calc.CurrentNumberString;
      History.Text = string.Join("\n", Calc.History);
      EqualBtn.Focus();
    }

    private void DecimalPoint_Btn_Click(object sender, EventArgs e)
    {
      Calc.InputDecimalPoint();
      Display.Text = Calc.CurrentNumberString;
      History.Text = string.Join("\n", Calc.History);
      EqualBtn.Focus();
    }

    private void Delete_Btn_Click(object sender, EventArgs e)
    {
      Calc = new();
      Display.Text = "0";
      History.Text = "";
      EqualBtn.Focus();
    }

    private void Operator_Btn_Click(object sender, EventArgs e)
    {
      Calc.InputOperator(((Button)sender).Text[0]);
      History.Text = string.Join("\n", Calc.History);
      EqualBtn.Focus();
    }

    private void PiBtn_Click(object sender, EventArgs e)
    {
      Calc.InputPI();
      Display.Text = Calc.CurrentNumberString;
      History.Text = string.Join("\n", Calc.History);
      EqualBtn.Focus();
    }

    private void SquareRootBtn_Click(object sender, EventArgs e)
    {
      Calc.CalculateSquareRoot();
      Display.Text = Calc.CurrentNumberString;
      History.Text = string.Join("\n", Calc.History);
      EqualBtn.Focus();
    }

    private void EqualBtn_Click(object sender, EventArgs e)
    {
      Calc.Calculate();
      Display.Text = Calc.CurrentNumberString;
      History.Text = string.Join("\n", Calc.History);
    }
  }
}