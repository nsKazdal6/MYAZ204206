using Queue;

namespace QueueTests
{
    public class LinkedListQueueTests
    {
        [Theory]
        [InlineData(5)]
        public void LinkedListQueue_EnQueue(int item)
        {
            var queue = new LinkedListQueue<int>();

            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(item);

            Assert.Equal(4, queue.Count);
        }
        [Theory]
        [InlineData(5)]
        public void LinkedListQueue_DeQueue(int item)
        {
            var queue = new LinkedListQueue<int>();

            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(item);
            var result = queue.DeQueue();

            Assert.Equal(3, queue.Count);
            Assert.Equal(1, result);
        }
        [Theory]
        [InlineData(5)]
        public void LinkedListQueue_Peek(int item)
        {
            var queue = new LinkedListQueue<int>();

            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(item);
            var result = queue.Peek();

            Assert.Equal(4, queue.Count);
            Assert.Equal(1, result);
        }

        [Fact]
        public void LinkedList_IEnumarble_Constructor()
        {
            var queue = new LinkedListQueue<char>("ahmet".ToArray());

            Assert.Equal(5, queue.Count);
            Assert.Equal('a', queue.Peek());
        }

    }
}