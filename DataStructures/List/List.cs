using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace List
{
    public class List<T> : IEnumerable<T>
    {
        private T[] _list;

        private int index = 0;

        public int Capacity => _list.Length;

        public int Count => index;

        public List()
        {
            _list = new T[4];
        }

        public void Add(T item)
        {
            if (index == _list.Length)
            {
                DoubleList(_list);
            }
            _list[index] = item;
            index++;
        }

        public void DoubleList(T[] list)
        {
            var newList = new T[list.Length * 2];
            System.Array.Copy(list, newList, _list.Length);
            _list = newList;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Remove(T item)
        {
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(item))
                {
                    _list[i] = default(T);
                    for (int j = i; j < _list.Length - 1; j++)
                    {
                        T temp = _list[j];
                        _list[j] = _list[j + 1];
                        _list[j + 1] = temp;
                    }

                    index--;
                    if (index == _list.Length / 2)
                        HalfList(_list);
                    return true;
                }
            }

            return false;
        }

        public void HalfList(T[] list)
        {
            var newList = new T[list.Length / 2];
            System.Array.Copy(list, newList, newList.Length);
            _list = newList;
        }

        public void RemoveAt(int index)
        {
            _list[index] = default(T);

            for (int i = index; i < _list.Length - 1; i++)
            {
                T temp = _list[i];
                _list[i] = _list[i + 1];
                _list[i + 1] = temp;
            }
        }

        public T[] InterSect(IEnumerable<T> collection)
        {
            var x = 0;
            T[] newlist = new T[_list.Length];
            foreach (var item in _list.Intersect(collection))
            {
                if (item != null)
                {
                    newlist[x] = item;
                    x++;
                }
            }
            return newlist;
        }

        public T[] Union(IEnumerable<T> collection)
        {
            var x = 0;
            T[] newlist = new T[_list.Length];
            foreach (var item in _list.Union(collection))
            {
                if (item != null)
                {
                    newlist[x] = item;
                    x++;
                }
            }
            return newlist;

        }

        public T[] Except(IEnumerable<T> collection)
        {
            var x = 0;
            T[] newlist = new T[_list.Length];
            foreach (var item in _list.Except(collection))
            {
                if (item != null)
                {
                    newlist[x] = item;
                    x++;
                }
            }
            return newlist;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.Take(index).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        
    }
}