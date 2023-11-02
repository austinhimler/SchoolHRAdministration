using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRAdministrationAPI
{
    //instaniates object generically, even though generically created
    //enables code to be strongly typed and checked at compile time
    public static class FactoryPattern<K, T> where T : class, K , new()
    {
        public static K GetInstance()
        {
            K objK;
            objK = new T();
            return objK;
        }
    }
}
