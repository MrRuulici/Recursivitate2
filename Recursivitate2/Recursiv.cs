using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate2
{
    class Recursiv
    {
        public static int Maxim(int[] v, int n, int mx)
        {
            if (n == 0)
            {
                if (mx >= v[n])
                    return mx;
                else return v[n];
            }
            else
            {
                if (mx >= v[n])
                    return Maxim(v, n - 1, mx);
                else
                    return Maxim(v, n - 1, v[n]);
            }
        }
    }
}
