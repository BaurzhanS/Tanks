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
        public TankPantera()
        {
            Random r = new Random();
            
            this.weapon = r.Next(0, 100);
            this.armour = r.Next(0, 100);
            this.mobility = r.Next(0, 100);
        }
    }
}
