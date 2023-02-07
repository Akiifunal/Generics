using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyDictionary<T>
    {
        T[] Array;
        T[] _TempArray;
        public MyDictionary()
        {
            Array = new T[0];
        }

       

        public void Add(T item)
        {
           _TempArray = Array;
            Array = new T[_TempArray.Length + 1];
            for (int i = 0; i < _TempArray.Length; i++)
            {
                _TempArray[i] = Array[i];
            }
            Array[Array.Length - 1] = item;


        }
        public int Length
        {
            get { return Array.Length; }
        }
    }
}
