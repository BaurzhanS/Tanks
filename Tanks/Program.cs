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
            List<TankT34> t34 = new List<TankT34>();
            List<TankPantera> panteras = new List<TankPantera>();
            for (int i = 0; i < 10; i++)
            {
                TankT34 t = new TankT34();
                t34.Add(t);
                TankPantera p = new TankPantera();
                panteras.Add(p);
                bool a = t34[i] * panteras[i];
                Console.WriteLine("T34: {0}, {1}, {2}", t34[i].armour, t34[i].mobility, t34[i].weapon);
                Console.WriteLine("Pantera: {0}, {1}, {2}", panteras[i].armour, panteras[i].mobility, panteras[i].weapon);
                Console.WriteLine();
            }

            


            
        }
    }
}
