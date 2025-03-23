using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_02_02
{
    class @class
    {
        public class Player: MonoBehaviour
        {
            private string ID = "백박사";
            private int currentHP = 1000;

            public void TakeDamage(int damage)
            {
                if (currentHP > damage)
                {
                    currentHP -= damage;
                }
            }
        }
    }
}
