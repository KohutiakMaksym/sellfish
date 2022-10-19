using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfishBackendMySql
{
    public class Hash
    {
        public int getHash(string str)
        {
            const int p = 31;
            const double m = 1e9 + 7;
            int hash = 0;
            int p_pow = 1;
            for (int i = 0; i < str.Length; i++)
            {
                hash = (int)((hash + (str[i] - 'a' + 1) * p_pow) % m);
                p_pow = (int)((p_pow * p) % m);
            }
            return hash;
        }        
    }
}
