using System.Collections;

namespace Array
{
    public class Array 
    {
        private Object[] _InnerArray;
        private int index = 0;
        public int Count => index;
        public int Capacity => _InnerArray.Length;

        public Array()
        {
            _InnerArray = new Object[4];
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

        public Object Find(Object item)
        {
            for (int i = 0; i < _InnerArray.Length; i++)
            {
                if (item == _InnerArray[i])
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

        public Object RemoveItem(int position)
        {
            var item =GetItem(position);
            if (item != null)
            {
                _InnerArray[position] = null;
                return item;
            }
            return -1;
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
    }

}