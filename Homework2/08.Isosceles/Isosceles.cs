using System;
using System.Text;
class Isosceles
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char varOne = '\u00A9';
        Console.WriteLine("   " + "{0}", varOne);
        Console.WriteLine("  " + "{0} {0}", varOne);
        Console.WriteLine(" " + "{0}   {0}", varOne);
        Console.WriteLine("{0} {0} {0} {0}", varOne);
    }
}
