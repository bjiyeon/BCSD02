using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_02_02
{
    class membermethod
    {
        public class Player : Monobehaviour
        {
            private string ID = "백지연";
            private int currentHP = 1234;

            private void Awake()
            {
                TakeDamage(100);
            }

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
