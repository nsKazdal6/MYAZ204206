using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");
            array.Add("Elif");

            int count = array.Count;

            Assert.Equal(3, array.Count);
            Assert.Equal(4, array.Capacity);
        }

        [Fact]
        public void Array_Add_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");
            array.Add("Elif");
            array.Add("Kader");
            array.Add("Berra");

            int count = array.Count;

            Assert.Equal(5, array.Count);
            Assert.Equal(8, array.Capacity);
        }

        [Fact]
        public void Array_GetItem_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");

            var item =array.GetItem(1);

            Assert.Equal(item,"Fatma");
        }

        [Fact]
        public void Array_GetItem_Exception_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add("Ahmet");
                array.Add("Fatma");

                var item =array.GetItem(-1);

                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Array_Find_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");

            var item1 = array.Find("Fatma");
            var item2 = array.Find("Elif");

            Assert.Equal(item1, 1);
            Assert.Equal(item2, -1);
        }

        [Fact]
        public void Array_Swap_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");
            array.Add("Elif");

            array.Swap(0, 2);
            var item1 = array.GetItem(0);
            var item2 = array.GetItem(2);

            Assert.Equal(item1, "Elif");
            Assert.Equal(item2, "Ahmet");
        }

        [Fact]
        public void Array_RemoveItem_Exception_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add(0);
                array.Add(1);

                var item = array.RemoveItem(-1);

                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Array_RemoveItem_Test()
        {
            var array=new Array.Array();
            array.Add(0);
            array.Add(1);

            var item1 =array.RemoveItem(0);
            var item2 =array.RemoveItem(2);

            Assert.Equal(item1, 0);
            Assert.Equal(item2, -1);
        }

        [Fact]
        public void Array_Remove_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add("Ahmet");
                array.Add("Fatma");

                var item1 =array.Remove();
                var item2 =array.Remove();

                Assert.Equal(item1, "Fatma");
                Assert.Equal(item2, "Ahmet");
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Array_Remove_Exception_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add(0);

                var item1 = array.Remove();

                Assert.False(false);
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Array_GetEnumerator_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");
            array.Add("Elif");

            string result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);
            }

            Assert.Equal(result, "AhmetFatmaElif");
        }

    }
}