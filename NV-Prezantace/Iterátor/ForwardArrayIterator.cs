using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NV_Prezentace.Iterátor
{
    class ForwardArrayIterator<T> : SimpleIterator<T>
    {
        private T[] array;
        private int index;
        public ForwardArrayIterator(T[] array)
        {
            this.array = array;
            index = -1;
        }
        public bool HasNext()
        {
            return index < array.Length - 1;
        }

        public T Next()
        {
            index++;
            Debug.Assert(index <= array.Length - 1);
            return array[index];
        }
    }
}
