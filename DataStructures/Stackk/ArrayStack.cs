﻿using Stackk.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackk
{
    public class ArrayStack<T> : IStack<T>
    {
        private List<T> _innerArray;

        private int LastIndex => Count - 1;
        public int Count => _innerArray.Count;
        public ArrayStack()
        {
            _innerArray= new List<T>();
        }
        public ArrayStack(IEnumerable<T>collection) : this()
        {
            foreach (var item in collection)
            {
                Push(item);
            }
        }

        public T Peek()
        {
            return LastIndex == 0
                ? default(T)
                : _innerArray[LastIndex];
        }

        public T Pop()
        {
            if (Count==0)
            {
                throw new Exception("Underflow! Empty stack!");
            }
            var temp = _innerArray[LastIndex];
            _innerArray.RemoveAt(LastIndex);
            return temp;
        }

        public void Push(T item)
        {
            _innerArray.Add(item);
        }
    }
}
