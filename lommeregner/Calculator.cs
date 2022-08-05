using System.Windows.Forms;
namespace lommeregner
{
    public static class Calculator
    {
        public static void ButtonClick(string buttonName, List<string> enteries, TextBox display)
        {
            string[] splitButtonName = buttonName.Split("_");
            if(splitButtonName.Length > 0)
            {
                if (splitButtonName[0] == "Num")
                {
                    if (splitButtonName[1].Length == 1)
                    {
                        enteries.Add(splitButtonName[1]);
                        display.Text = display.Text + splitButtonName[1];
                    }
                }
                else
                {
                    switch (splitButtonName[0])
                    {
                        case "Decimal":
                            enteries.Add(".");
                            display.Text = display.Text + ".";
                            break;
                        case "Add":
                            enteries.Add("+");
                            display.Text = display.Text + " + ";
                            break;
                        case "Subtract":
                            enteries.Add("-");
                            display.Text = display.Text + " - ";
                            break;
                        case "Multiply":
                            enteries.Add("*");
                            display.Text = display.Text + " * ";
                            break;
                        case "Divide":
                            enteries.Add("/");
                            display.Text = display.Text + " / ";
                            break;
                    }
                }
            }
        }
    }
}