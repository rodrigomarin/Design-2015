using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fibonacci
    {
        public static int Calcular(int f)
        {
            if (f == 1)
            {
                return 1;
                
            }
            else if (f == 2)
            {
                return 1;
               
            }
            return f - 1;

            

        }
    }
}
