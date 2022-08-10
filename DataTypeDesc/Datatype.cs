using System.Runtime.InteropServices;
using Spectre.Console;

namespace DataTypeDesc
{
    public static class Datatype
    {
        public static unsafe void PrintVariableInformation<T>(ref T datatype)
        {
            AnsiConsole.Write(new FigletText(datatype.GetType().Name).LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Min Value");
            table.AddColumn("Max Value");

            table.AddRow(Marshal.SizeOf(datatype).ToString(), typeof(T).GetField("MinValue").GetValue(datatype).ToString(), typeof(T).GetField("MaxValue").GetValue(datatype).ToString());

            AnsiConsole.Write(table);
        }
    }
}