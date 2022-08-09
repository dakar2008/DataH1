using Spectre.Console;

namespace DataTypeDesc
{
    internal class Program
    {
        public sealed class Fruit : IBarChartItem
        {
            public string Label { get; set; }
            public double Value { get; set; }
            public Color? Color { get; set; }

            public Fruit(string label, double value, Color? color = null)
            {
                Label = label;
                Value = value;
                Color = color;
            }
        }
        static void Main(string[] args)
        {
            var items = new List<Fruit>
            {
                new Fruit("sbyte", 8, Color.Yellow),
                new Fruit("byte", 8, Color.LightSalmon3_1),
                new Fruit("short", 16, Color.LightCyan3),
                new Fruit("ushort", 16, Color.HotPink_1),
                new Fruit("char", 16, Color.Orange3),
                new Fruit("string", 32, Color.Aqua),
                new Fruit("int", 32, Color.GreenYellow),
                new Fruit("array", 32, Color.Gold1),
                new Fruit("uint", 32, Color.DarkCyan),
                new Fruit("long", 64, Color.Chartreuse3),
                new Fruit("ulong", 64, Color.CadetBlue),
                new Fruit("float", 64, Color.BlueViolet),
                new Fruit("double", 64, Color.Blue),
                new Fruit("decimal", 128, Color.Red),
            };
            while (true)
            {
                AnsiConsole.Write(new FigletText("Data Type Info").LeftAligned().Color(Color.Blue));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("Following datatypes are avalible: [green]sbyte[/] : [green]byte[/]: [green]short[/]: [green]ushort[/]: [green]int[/]: [green]uint[/]: [green]long[/]: [green]ulong[/]: [green]float[/]: [green]double[/]: [green]decimal[/]: [green]bool[/]"));
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new Markup("[orange3]Write [green]diagram[/] for a visual diagram of datatypes[/]"));
                AnsiConsole.WriteLine();
                Console.Write("Enter a datatype: ");
                string? userinput = Console.ReadLine();
                switch (userinput.ToLower())
                {
                    case "sbyte":
                        {
                            sbyte variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "byte":
                        {
                            byte variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "short":
                        {
                            short variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "ushort":
                        {
                            ushort variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "int":
                        {
                            int variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "uint":
                        {
                            uint variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "long":
                        {
                            long variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "ulong":
                        {
                            ulong variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "float":
                        {
                            float variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "double":
                        {
                            double variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "decimal":
                        {
                            decimal variable = 5;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }

                    case "bool":
                    case "boolean":
                        {
                            bool variable = true;
                            Datatype.PrintVariableInformation(ref variable);
                            break;
                        }
                    case "diagram":
                        {
                            AnsiConsole.WriteLine();
                            AnsiConsole.Write(new BarChart().Width(64).Label("[green bold underline]Datatypes[/]").CenterLabel().AddItems(items));
                            AnsiConsole.WriteLine();
                            break;
                        }
                    case "exit":
                    case "quit":
                        {
                            return;
                        }
                    default:
                        AnsiConsole.Write(new Markup("[red]Invalid datatype[/]"));
                        AnsiConsole.WriteLine();
                        break;
                }
            }
        }
    }
}