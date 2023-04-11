using Linkedlist.Singly;
using System.ComponentModel.DataAnnotations;

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
        [Fact]
        public void SinglyLinkedList_AddBefore_Throw_ExceptionTest()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(40);

            var node = new SinglyLinkedListNode<int>(30);

            Assert.Throws<Exception>(() => linkedList.AddBefore(node,50));

        }
        [Fact]
        public void SinglyLinkedList_AddAfter_Test()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(30);

            linkedList.AddAfter(linkedList.Head.Next, 100);

            Assert.Equal(linkedList.Head.Value, 30);
            Assert.Equal(linkedList.Head.Next.Next.Value, 100);


        }
        [Fact]
        public void SinglyLinkedList_AddAfter_Throw_ExceptionTest()
        {
            var linkedList = new SinglyLinkedList<int>();

            linkedList.AddFirst(10);
            linkedList.AddFirst(20);
            linkedList.AddFirst(30);

            var node = new SinglyLinkedListNode<int>(100);

            Assert.Throws<Exception>(() => linkedList.AddAfter(node, 100));

        }
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            var item = linkedList.RemoveFirst();

            Assert.Equal('c', item);
            Assert.Equal('b', linkedList.Head.Value);
        }
        [Fact]
        public void SinglyLinkedList_RemoveFirst_One_İtem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');

            var item = linkedList.RemoveFirst();

            Assert.Equal('a', item);
            Assert.True(linkedList.Head is null);
        }
        [Fact]
        public void SinglyLinkedList_RemoveFirst_Exception_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
           
            Assert.Throws<Exception>(()=> linkedList.RemoveFirst());
        }
        [Fact]
        public void SinglyLinkedList_RemoveLast_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');
            linkedList.AddFirst('b');
            linkedList.AddFirst('c');

            var item1 = linkedList.RemoveLast();
            var item2 = linkedList.RemoveLast();
            var item3 = linkedList.RemoveLast();

            Assert.Equal('a', item1);
            Assert.Equal('b', item2);
            Assert.Equal('c', item3);
        }
        [Fact]
        public void SinglyLinkedList_RemoveLast_Exception_Test()
        {
            var linkedList = new SinglyLinkedList<char>();

            Assert.Throws<Exception>(() => linkedList.RemoveLast());
        }
        [Fact]
        public void SinglyLinkedList_Remove_LastItem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   
            linkedList.AddFirst('b');   
            linkedList.AddFirst('c');   

            var node = new SinglyLinkedListNode<char>('a');

            var item1 = linkedList.Remove(node);

            Assert.Equal('a', item1);
        }

        [Fact]
        public void SinglyLinkedList_Remove_MiddleItem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');  
            linkedList.AddFirst('b');   
            linkedList.AddFirst('c');   

            var node = new SinglyLinkedListNode<char>('b');

            var item1 = linkedList.Remove(node);

            Assert.Equal('b', item1);
        }

        [Fact]
        public void SinglyLinkedList_Remove_FirstItem_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   
            linkedList.AddFirst('b');   
            linkedList.AddFirst('c');   

            var node = new SinglyLinkedListNode<char>('c');

            var item1 = linkedList.Remove(node);

            Assert.Equal('c', item1);
        }

        [Fact]
        public void SinglyLinkedList_Remove_Exception_Test()
        {
            
            var linkedList = new SinglyLinkedList<char>();

            var node = new SinglyLinkedListNode<char>('b');

            Assert.Throws<Exception>(() => linkedList.Remove(node));
        }
        [Fact]
        public void SinglyLinkedList_Remove_Exception2_Test()
        {
            var linkedList = new SinglyLinkedList<char>();
            linkedList.AddFirst('a');   
            linkedList.AddFirst('b');   
            linkedList.AddFirst('c');   

            var node = new SinglyLinkedListNode<char>('x');

            Assert.Throws<Exception>(() => linkedList.Remove(node));

        }
        [Fact]
        public void SinglyLinkedList_Get_Enumerator_Test()
        {
            var list = new SinglyLinkedList<char>("rize".ToArray());

            Assert.Collection<char>(list,
                item => Assert.Equal('e', item),
                item => Assert.Equal('z', item),
                item => Assert.Equal('i', item),
                item => Assert.Equal('r', item));


        }
    }
}