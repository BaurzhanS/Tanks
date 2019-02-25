using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class TankT34
    {
        public int weapon{private set;get;}
        public int armour { private set; get; }
        public int mobility { private set; get; }
        public static Random r = new Random();
        public TankT34()
        {
            this.weapon = r.Next(0, 100);
            this.armour = r.Next(0, 100);
            this.mobility = r.Next(0, 100);
        }
        public static bool operator *(TankT34 t1, TankPantera t2)
        {
            int t34 = 0;
            int pantera = 0;
            if (t1.armour > t2.armour) t34++;
            if (t1.mobility > t2.mobility) t34++;
            if (t1.weapon > t2.weapon) t34++;
            if (t1.armour < t2.armour) pantera++;
            if (t1.mobility < t2.mobility) pantera++;
            if (t1.weapon < t2.weapon) pantera++;

            if (t34 > 1)
            {
                Console.WriteLine("Выиграл танк Т-34!");
                return true;
            }
            else if (pantera > 1)
            {
                Console.WriteLine("Выиграл танк Пантера!");
                return true;
            }
            else
            {
                Console.WriteLine("Никто не выиграл!");
                return false;
            }

        }
    }
}
