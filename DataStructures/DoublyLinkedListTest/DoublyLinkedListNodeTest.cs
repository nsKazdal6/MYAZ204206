using Linkedlist.Doubly;

namespace DoublyLinkedListTest
{
    public class DoublyLinkedListNodeTest
    {
        [Fact]
        public void DbNode_Test()
        {
            var node = new DbNode<int>();

            node.Value= 1;
            node.Next= new DbNode<int> { Value = 2 };
            node.Next.Prev = node;
            node.Next.Next= new DbNode<int> { Value = 3 };
            node.Next.Next.Prev = node.Next;

            Assert.Equal(1, node.Value);
            Assert.Equal(2, node.Next.Value);
            Assert.Equal(1, node.Next.Prev.Value);
            Assert.Equal(3, node.Next.Next.Value);
        }
    }
}