using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P129Indexer.Lists
{
    class MyList<T> : IEnumerable
    {
        private T[] _arr;

        public MyList()
        {
            _arr = new T[1000];
        }

        //Indexer
        public T this[int index]
        {
            get{
                if (index >= 0 && index < _arr.Length)
                {
                    return _arr[index];
                }
                throw new IndexOutOfRangeException("Index Sehfdir");
            }
            set
            {
                if (index >= 0 && index < _arr.Length)
                {
                    _arr[index] = value;
                    return;
                }
                throw new IndexOutOfRangeException("Index Sehfdir");
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public T ElemetAt(int index)
        {
            if (index >= 0 && index < _arr.Length)
            {
                return _arr[index];
            }

            throw new IndexOutOfRangeException("Daxil Edilen Index Yanlisdir");
        }

        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }
    }
}
