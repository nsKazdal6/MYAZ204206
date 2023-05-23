using Stackk;
using System.Data;

namespace StackTest
{
    public class UnitTest1
    {
        [Fact]
        public void LinkedListStack_Push_Test()
        {
            var stack = new LinkedListStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.Equal(3, stack.Count);

        }
        [Fact]
        public void LinkedListStack_Pop_Test()
        {
            var stack = new LinkedListStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Pop();

            Assert.Equal(2, stack.Count);
            Assert.Equal(3, result);

        }
        [Fact]
        public void LinkedListStack_Peek_Test()
        {
            var stack = new LinkedListStack<string>();

            stack.Push("Ahmet");
            stack.Push("Fatma");
            stack.Push("Berra");

            var result = stack.Peek();

            Assert.Equal(3, stack.Count);
            Assert.Equal("Berra", result);

        }
        [Fact]
        public void LinkedListStack_Constructor_IEnumerable_Test()
        {
            var stack = new ArrayStack<int>(new List<int> { 1, 2, 3 });

            var result = stack.Peek();

            Assert.Equal(3, stack.Count);
            Assert.Equal(3, result);
        }
    }
}