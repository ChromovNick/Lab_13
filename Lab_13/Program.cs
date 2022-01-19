using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building ("СПб,Смольный проезд, д.1", 120, 300, 30);
            Console.WriteLine(building.Print());
            Multibuilding multibuilding = new Multibuilding("СПб,Невский проспект, д.133", 200, 500, 35,4);
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }
    }
}
