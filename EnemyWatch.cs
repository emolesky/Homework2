using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WatchTower
{
    public class EnemyWatch
    {
        private int x;
        private int y;


        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public EnemyWatch(int aX, int aY)
        {
            this.x = aX;
            this.y = aY;
        }
        public string CalcDirection()
        {
            {
                if (x == 0 && y == 0)
                    return "The enemy is here!";
                if (x == 0 && y < 0)
                    return "The enemy is South!";
                if (x == 0 && y > 0)
                    return "The enemy is North!";
                if (x < 0 && y > 0)
                    return "The enemy is North West!";
                if (x < 0 && y == 0)
                    return "The enemy is West!";
                if (x < 0 && y < 0)
                    return "The enemy is South West!";
                if (x > 0 && y > 0)
                    return "The enemy is North East!";
                if (x > 0 && y == 0)
                    return "The enemy is East!";
                if (x > 0 && y < 0)
                    return "The enemy is South East!";
                return "Unknown Message";
            }
        }
    }
}
