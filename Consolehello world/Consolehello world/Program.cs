using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lees esto?
namespace Consolehello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            float ndm, cd;
            Console.WriteLine("Ingrese capacidad de Información almacenada en Gb");
            cd = int.Parse(Console.ReadLine());
            ndm = (cd * 1024) / 144;
            Console.Write("Los microdiscos necesarios son: " +ndm.ToString());
            Console.Read();
           
        }
    }
}
