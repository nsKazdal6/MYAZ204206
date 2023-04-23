using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist.Doubly
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        public DbNode<T> Head { get; set; }
        public DbNode<T> Tail { get; set; }
        public bool isHeadNull { get; set; }

        public DoublyLinkedList()
        {
            this.isHeadNull = isHeadNull;
        }
        public void AddFirst(T item)
        {
            var node = new DbNode<T>(item);
            if ((Head == null) && (Tail is null))
            {
                Head = node;
                Tail = node;
                isHeadNull = false;
            }
            node.Next = Head;
            Head.Prev = node;
            Head = node;
        }
        public void AddLast(T item)
        {
            var node = new DbNode<T>(item);
            if ((Head == null) && (Tail is null))
            {
                Head = node;
                Tail = node;
                isHeadNull = false;
            }
            node.Prev = Tail;
            Tail.Next = node;
            Tail = node;
        }
        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("The linked list is empty!");

            T item = default;
            if (Head.Equals(Tail))
            {
                item = Head.Value;
                Head = null;
                Tail = null; ;
                return item;
            }
            
            
            item = Head.Value;
            Head.Next.Prev = null;
            Head = Head.Next;
            return item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
