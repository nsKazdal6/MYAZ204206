namespace SortAlgorithm
{
    public class BubbleSort<T> where T : IComparable<T>
    {
        public static void Sort( T[] list)
        {
            bool isSorted = true;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length-i-1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        Swap(ref list[j], ref list[j + 1]);
                        isSorted = false;
                    }
                }
                if (isSorted==true)
                {
                    break;
                }
            }
            
        }


        private static void Swap(ref T x, ref T y)
        {
            var temp = x; 
            x = y;
            y = temp;
        }
    }
}