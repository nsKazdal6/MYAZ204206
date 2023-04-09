using Linkedlist.Singly;

namespace SinglyLinkedListTests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void SinglyLinkedList_AddFirst_Test()
        {
            var linkedlist = new SinglyLinkedList<int>();

            linkedlist.AddFirst(10);
            linkedlist.AddFirst(20);
            linkedlist.AddFirst(30);

            Assert.Equal(linkedlist.Head.ToString(), "30");
            Assert.Equal(linkedlist.Head.Next.Value, 20);
            Assert.Equal(linkedlist.Head.Next.Next.Value, 10);


        }
        [Fact]
        public void SinglyLinkedList_AddLast_Test()
        {
            var linkedlist = new SinglyLinkedList<int>();

            linkedlist.AddFirst(10);
            linkedlist.AddFirst(20);
            linkedlist.AddLast(30);
            linkedlist.AddFirst(40);
            linkedlist.AddLast(50);

            Assert.Equal(linkedlist.Head.ToString(), "40");
            Assert.Equal(linkedlist.Head.Next.Value, 20);
            Assert.Equal(linkedlist.Head.Next.Next.Value, 10);
            Assert.Equal(linkedlist.Head.Next.Next.Next.Value, 30);
            Assert.Equal(linkedlist.Head.Next.Next.Next.Next.Value, 50);


        }
    }
}