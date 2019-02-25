using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class TankPantera
    {
        public int weapon { private set; get; }
        public int armour { private set; get; }
        public int mobility { private set; get; }
        //public static Random r = new Random();
        public TankPantera()
        {
            this.weapon = TankT34.r.Next(0, 100);
            this.armour = TankT34.r.Next(0, 100);
            this.mobility = TankT34.r.Next(0, 100);
        }
    }
}
