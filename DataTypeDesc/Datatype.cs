using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace DataTypeDesc
{
    public static class Datatype
    {
        public static unsafe void PrintVariableInformation(ref sbyte datatype)
        {
            AnsiConsole.Write(new FigletText("sbyte").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            sbyte testVariable;
            sbyte* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(sbyte).ToString(), sbyte.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref byte datatype)
        {
            AnsiConsole.Write(new FigletText("byte").LeftAligned().Color(Color.Red));
            
            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            byte testVariable;
            byte* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(byte).ToString(), byte.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref short datatype)
        {
            AnsiConsole.Write(new FigletText("short").LeftAligned().Color(Color.Red));
            
            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            short testVariable;
            short* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(short).ToString(), short.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref ushort datatype)
        {
            AnsiConsole.Write(new FigletText("ushort").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            ushort testVariable;
            ushort* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(ushort).ToString(), ushort.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref int datatype)
        {
            AnsiConsole.Write(new FigletText("int").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            int testVariable;
            int* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(int).ToString(), int.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref uint datatype)
        {
            AnsiConsole.Write(new FigletText("uint").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            uint testVariable;
            uint* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(uint).ToString(), uint.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref long datatype)
        {
            AnsiConsole.Write(new FigletText("long").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            long testVariable;
            long* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(long).ToString(), long.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref ulong datatype)
        {
            AnsiConsole.Write(new FigletText("ulong").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            ulong testVariable;
            ulong* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(ulong).ToString(), ulong.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref float datatype)
        {
            AnsiConsole.Write(new FigletText("float").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            float testVariable;
            float* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(float).ToString(), float.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref double datatype)
        {
            AnsiConsole.Write(new FigletText("double").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            double testVariable;
            double* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(double).ToString(), double.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref decimal datatype)
        {
            AnsiConsole.Write(new FigletText("decimal").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            decimal testVariable;
            decimal* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(decimal).ToString(), decimal.MaxValue.ToString("N").Replace(",00", ""), add.ToString("X"));

            AnsiConsole.Write(table);
        }
        public static unsafe void PrintVariableInformation(ref bool datatype)
        {
            AnsiConsole.Write(new FigletText("bool").LeftAligned().Color(Color.Red));

            var table = new Table();
            table.AddColumn("Size In Bytes");
            table.AddColumn("Max Value");
            table.AddColumn("Hex");

            bool testVariable;
            bool* pointer = &testVariable;
            IntPtr add = (IntPtr)pointer;

            table.AddRow(sizeof(bool).ToString(), "1", add.ToString("X"));

            AnsiConsole.Write(table);
        }
    }
}