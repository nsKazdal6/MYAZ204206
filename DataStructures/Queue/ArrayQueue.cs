using Queue.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private List<T> _innerArray;

        public ArrayQueue()
        {
            _innerArray = new List<T>();
        }
        public ArrayQueue(IEnumerable<T> collection) :this()
        {
            foreach (var item in collection)
            {
                EnQueue(item);
            } 
        }
        public int Count => _innerArray.Count;

        public T DeQueue()
        {
            if (_innerArray.Count == 0)
                throw new Exception("The queue is empty!");
            var temp = _innerArray[0];
            _innerArray.RemoveAt(0);
            return temp;
        }

        public void EnQueue(T item)
        {
            _innerArray.Add(item);
        }

        public T Peek()
        {
            return Count == 0 ? default : _innerArray[0];
        }
    }
}
