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
    }
}