using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Part1;

namespace Part2
{
    public static class ExtendedPrinter
    {
        public static void PrinterArray(this Printer printer, params string[] msgs)
        {
            foreach (var msg in msgs)
            {
                printer.Print(msg);
            }
        }

        public static void ColorPrinterArray(this ColorPrinter printer, ConsoleColor color, params string[] msgs)
        {
            foreach (var msg in msgs)
            {
                printer.Print(msg, color);
            }
        }

        public static void PhotoPrinterArray(this PhotoPrinter printer, params Photo[] msgs)
        {
            foreach (var msg in msgs)
            {
                printer.Print(msg);
            }
        }
    }
}