using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTests
{
    public class ArrayQueueTests
    {
        [Fact]
        public void ArrayQueue_Enqueue_Test()
        {
            var queue = new  Queue.ArrayQueue<char>("ahmet");

            Assert.Equal(5, queue.Count);
        }
        [Fact]
        public void ArrayQueue_Dequeue_Test()
        {
            var queue = new Queue.ArrayQueue<char>("ahmet");

            var item = queue.DeQueue();

            Assert.Equal(4, queue.Count);
            Assert.Equal('a',item);
        }
        [Fact]
        public void ArrayQueue_Dequeue_Exception_Test()
        {
            var queue = new Queue.ArrayQueue<char>();
            Assert.Throws<Exception>(() => queue.DeQueue());
        }
        [Fact]
        public void ArrayQueue_Peek_Test()
        {
            var queue = new Queue.ArrayQueue<char>("ahmet");

            Assert.Equal('a',queue.Peek());
        }
    }
}
