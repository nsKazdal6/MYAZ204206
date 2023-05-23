using Stackk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class ArrayStackTests
    {
        [Fact]
        public void ArrayStack_Push_Test()
        {
            var stack = new ArrayStack<int>();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.Equal(3, stack.Count);
        }
        [Fact]
        public void ArrayStack_Pop_Test()
        {
            var stack = new ArrayStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result= stack.Pop();

            Assert.Equal(2, stack.Count);
            Assert.Equal(3, result);
        }
        [Fact]
        public void ArrayStack_Peek_Test()
        {
            var stack = new ArrayStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var result = stack.Peek();

            Assert.Equal(3, stack.Count);
            Assert.Equal(3, result);
        }
        [Fact]
        public void ArrayStack_Constructor_IEnumerable_Test()
        {
            var stack = new ArrayStack<int>(new List<int> { 1,2,3});

            var result = stack.Peek();

            Assert.Equal(3, stack.Count);
            Assert.Equal(3, result);
        }
    }
}
