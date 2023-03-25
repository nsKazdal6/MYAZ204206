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
    }
}