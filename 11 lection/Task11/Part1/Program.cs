using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            var colorPr = new ColorPrinter();
            var photoPr = new PhotoPrinter();
            var photo = new Photo();
            printer.Print("Test text");
            colorPr.Print("Color printer text");
            colorPr.Print("Color printer text", ConsoleColor.Yellow);
            photoPr.Print("Photo printer text");
            photoPr.Print(photo);
            Console.ReadLine();
        }
    }
}
