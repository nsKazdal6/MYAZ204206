using Linkedlist.Doubly;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListTest
{
    public class DoublyLinkedListTest
    {
        [Fact]
        public void DbLinkedList_AddFirst_Test()
        {
            var linkedList = new DoublyLinkedList<int>();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);

            Assert.Equal(4, linkedList.Head.Value);
            Assert.Equal(3, linkedList.Head.Next.Value);
            Assert.Equal(2, linkedList.Tail.Prev.Value);
            Assert.Equal(1, linkedList.Tail.Value);
        }

        [Fact]
        public void DbLinkedList_AddLast_Test()
        {
            var linkedList = new DoublyLinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            Assert.Equal(4, linkedList.Tail.Value);
            Assert.Equal(3, linkedList.Tail.Prev.Value);
            Assert.Equal(2, linkedList.Head.Next.Value);
            Assert.Equal(1, linkedList.Head.Value);
        }
        [Fact]
        public void DbLinkedList_RemoveFirst_Test()
        {
            var linkedList = new DoublyLinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);

            var item1 = linkedList.RemoveFirst();
            var item2 = linkedList.RemoveFirst();
            var item3 = linkedList.RemoveFirst();
            var item4 = linkedList.RemoveFirst();

            Assert.Equal(1,item1);
            Assert.Equal(2,item2);
            Assert.Equal(3,item3);
            Assert.Equal(4,item4);
        }
    }
}
