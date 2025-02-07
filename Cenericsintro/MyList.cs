using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenericsintro
{
    class MyList<T>
    {
        T[] items;
        //constructor:
        public MyList(T item)
        {
            items = new T[0];//bir clas newlendiğinde çalışan bloğa constructor denir.

        }
        public void Add(T item) {
            T[] tempArry = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArry.Length; i++) {
                items[i] = tempArry[i];
            }
            items[items.Length - 1]=item;
        }
    }
}
