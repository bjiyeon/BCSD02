using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCSD_02_02
{
    class Shallow_copy
    {
        public class GameController : MonoBehaviour
        {
            private Player player01;
            private Player player02;

            private void Awake()
            {
                player01 = new Player("백박사", 1000);
                player02 = player01;
                player02.ID = "유니티";

                Debug.Log($"ID : {player01.ID}");
                Debug.Log($"ID : {player02.ID}");
            }
        }
    }
}
