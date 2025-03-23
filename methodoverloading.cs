using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백지연_BCSD_02_01
{
    class methodoverloading
    {
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Debug.Log($"{num1}+{num2}={result}");
        }
        public void Add(float num1, float num2)
        {
            float result = num1 + num2;
            Debug.Log($"{num1}+{num2}={result}");
        }
    }
}
