using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백지연_BCSD_02_01
{
    class @out
    {
        private void Awake()
        {
            int a = 5, b = 4, result1 = 0, result2 = 0;
            Divide(a, b, out result1, out result2);
            Debug.Log($"몫={result1},나머지={result2}");
        }
        public void Divide(int num1, int num2, out int result1, out int result2)
        {
            result1 = num1/num2;
            result2 = num1%num2;

        }
    }
}
