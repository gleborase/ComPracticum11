using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Составить программу, в результате которой величина а меняется значением с величиной b, а величина c — с величиной d.
    /// </summary>
    internal class Program
    {
        static int Input(String message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");
            Console.WriteLine($"до обмена:{a}\t{b}\t{c}\t{d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.WriteLine($"после обмена:{a}\t{b}\t{c}\t{d}");
            Console.Read();
        }
        static void Swap(ref int x, ref int y)
        {
            int p= x;
            x=y;
            y=p;
        }
    }
}
