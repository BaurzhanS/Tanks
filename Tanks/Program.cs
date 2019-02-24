using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLib.WorldOfTanks;


namespace Tanks
{
    class Program
    {
        static void Main(string[] args)
        { 
            TankT34 t = new TankT34();
            TankPantera p = new TankPantera();
            bool a = t * p;

            Console.WriteLine("T34: {0}, {1}, {2}", t.armour, t.mobility, t.weapon);
            Console.WriteLine("Pantera: {0}, {1}, {2}", p.armour, p.mobility, p.weapon);
        }
    }
}
