using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_02_02
{
    class constructor
    {
        public class Player
        {
            public string ID;
            private int currentHP;

            public Player()
            {
                ID = "백박사";
                currentHP = 9999;
            }
        }
        public class GameController : MonoBehaviour
        {
            public Player player01;

            private void Awake()
            {
                player01 = new Player();
            }
        }
    }
}
