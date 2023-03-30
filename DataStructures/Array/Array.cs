using System.Collections;

namespace Array
{
    public class Array : IEnumerable
    {
        private Object[] _InnerArray;
        private int index = 0;
        public int Count => index;
        public int Capacity => _InnerArray.Length;

        public Array()
        {
            _InnerArray = new Object[4];
        }

        public Array(params Object[] init)
        {
            var newArray = new Object[init.Length];
            System.Array.Copy(init, newArray, init.Length);
            _InnerArray = newArray;
        }

        public void Add(Object item)
        {
            if (index == _InnerArray.Length)
            {
                DoubleArray(_InnerArray);
            }
            _InnerArray[index] = item;
            index++;
        }

        public void DoubleArray(object[] array) 
        { 
            var newArray = new Object[array.Length*2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray= newArray;
        }

        public Object GetItem(int position)
        {
            if (position<0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            return _InnerArray[position];
        }

        public void SetItem(int position, Object item)
        {
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            _InnerArray[position] = item;

        }

        public int Find(Object item)
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (item.Equals(_InnerArray[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Swap(int p1, int p2)
        {
            var temp = _InnerArray[p1];
            _InnerArray[p1] = _InnerArray[p2];
            _InnerArray[p2] = temp;
        }

        
        public Object Remove()
        {
            if (index == 0)
                throw new Exception("Out Of İndex!");
            if (index == _InnerArray.Length / 2)
                throw new NotImplementedException();
            var temp  = _InnerArray[index-1];
            _InnerArray[index] = null;
            index--;
            return temp;

            
        }

        public IEnumerator GetEnumerator()
        {
            return _InnerArray.GetEnumerator();
        }

        public Object RemoveItem(int position)
        {
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            var item = _InnerArray[position];
            _InnerArray[position] = null;
            for (int i = 0; i < _InnerArray.Length-1; i++)
            {
              Swap(i, i + 1);  
            }
            index--;
            if (index == _InnerArray.Length/2)
            {
                var newArray = new Object[_InnerArray.Length / 2];
                System.Array.Copy(_InnerArray, newArray, newArray.Length);
                _InnerArray = newArray;

            }
            return item;
            
        }
        public Object[] Copy(int v1, int v2)
        {
            var newArray = new Object[v2];
            int j = 0;
            for (int i = v1; i < v2; i++)
            {
                newArray[j] = GetItem(i);
                j++;
            }
            return newArray;
        }

        
 
    }

}