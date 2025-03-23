using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_02_02
{
    class accessmodifier
    {
        public class Player
        {
            public string ID;
            private int currentHP;

            void RecoveryHP(int hp)
            {
                currentHP += hp;
            }
            public void TakeDamage(int damage)
            {
                if (currentHP>damage)
                {
                    currentHP-=damage;
                }
            }
        }
    }
}
