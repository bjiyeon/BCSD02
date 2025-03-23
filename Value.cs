using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백지연_BCSD_02_01
{
    class Value
    {
        //값에 의한 전달
        private void Awake()
        {
            int a = 3, b = 4;
            Debug.Log($"Before a={a}, b={b}");
            Swap(a, b);
            Debug.Log($"After a={a}, b={b}");
        }

        public void Swap(int num1, int num2)
        {
            int temp = num1;
            num2 = num2;
            num2 = temp;
        }
    }
}
