using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_02_02
{
    class @this
    {
        public class Player
        {
            private string ID;
            private int currentHp;
            private int currnetMP;

            public Player()
            {
                ID = "백박사";
            }
            public Player(int hp) : this()
            {
                currentHp=hp;
            }
            public Player(int hp, int mp) : this(hp)
            {
                currnetMP=mp;
            }
        }
    }
}
