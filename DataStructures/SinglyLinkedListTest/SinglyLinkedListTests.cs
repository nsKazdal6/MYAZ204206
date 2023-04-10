using Linkedlist.Singly;

namespace SinglyLinkedListTests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void SinglyLinkedList_AddFirst_Test()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(30);

            Assert.Equal(linkedList.Head.ToString(), "30");
            Assert.Equal(linkedList.Head.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Value, 10);


        }
        [Fact]
        public void SinglyLinkedList_AddLast_Test()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddLast(30);
            linkedList.AddFirst(40);
            linkedList.AddLast(50);

            Assert.Equal(linkedList.Head.ToString(), "40");
            Assert.Equal(linkedList.Head.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Value, 10);
            Assert.Equal(linkedList.Head.Next.Next.Next.Value, 30);
            Assert.Equal(linkedList.Head.Next.Next.Next.Next.Value, 50);


        }
        [Fact]
        public void SinglyLinkedList_AddBefore_Test()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(40);

            linkedList.AddBefore(linkedList.Head.Next, 30);

            Assert.Equal(linkedList.Head.ToString(), "40");
            Assert.Equal(linkedList.Head.Next.Next.Value, 20);
            Assert.Equal(linkedList.Head.Next.Next.Next.Value, 10);
            Assert.Equal(linkedList.Head.Next.Value, 30);


        }
        public void SinglyLinkedList_AddBefore_Throw_ExceptionTest()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(40);

            var node = new SinglyLinkedListNode<int>(30);
            linkedList.AddBefore(node, 50);

            Assert.Throws<Exception>(() => linkedList.AddBefore(node,30));

        }
    }
}