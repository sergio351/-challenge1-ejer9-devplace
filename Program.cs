using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _9
{
    class Program
    {
        static void Main(string[] args )
        {
            float basemayor,altura,basemenor,area;
            Console.WriteLine("Ingresar base mayor");
            basemayor=float.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingresar base menor");
            basemenor=float.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingresar altura");
            altura=float.Parse(System.Console.ReadLine());
            area=((basemenor+basemayor)/2+altura);
            Console.WriteLine("El area es: "+area);

        }
    }
}
