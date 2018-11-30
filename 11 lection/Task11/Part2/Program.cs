using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using Part1;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var colorPr = new ColorPrinter();
            var photoPr = new PhotoPrinter();
            var photo1 = new Photo();
            var photo2 = new Photo();
            printer.PrinterArray("Text1", "Text2", "Text3");
            colorPr.ColorPrinterArray(ConsoleColor.Green, "Color printer text1", "Color printer text2", "Color printer text3");
            photoPr.PhotoPrinterArray(photo1, photo2);
            Console.ReadLine();
        }
    }
}