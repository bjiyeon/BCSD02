using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 백지연_BCSD_02_01
{
    class @return
    {
        private void Awake()
        {
            int a = Max(10, 20);
            Debug.Log(Max(100, 200));
        }
        public int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;
        }
        public void DIvide(int num1, int num2)
        {
            if (num2==0)
            {
                Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
                return;
            }

            float result = num1 / num2;
            Debug.Log($"{num1} / {num2} = {result}");
        }
    }
}
