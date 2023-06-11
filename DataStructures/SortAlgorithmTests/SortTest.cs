using SortAlgorithm;
using System.Linq.Expressions;

namespace SortAlgorithmTests
{
    public class SortTest
    {
        [Fact]
        public void BubbleSortTest()
        {
            var list = new int[] { 3,23,33,7,6,0,12};

            BubbleSort<int>.Sort( list);

            Assert.Collection(list,
                item => Assert.Equal(0, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(6, item),
                item => Assert.Equal(7, item),
                item => Assert.Equal(12, item),
                item => Assert.Equal(23, item),
                item => Assert.Equal(33, item));
        }
    }
}