using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist.Singly
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T>? Head { get; set; }
        public void AddFirst(T item)
        {
            var node = new SinglyLinkedListNode<T>()
            {
                Value = item 
            };
            if (Head == null)
            {
                Head = node;
                return;
            }
            node.Next= Head;
            Head = node;
            return;
        }
        public void AddLast(T item)
        {
            var node = new SinglyLinkedListNode<T>()
            {
                Value = item
            };

            if (Head == null)
            {
                Head = node;
                return;
            }

            var current = Head;
            var prev = current;
            while (current != null)
            {
                prev= current;
                current = current.Next;
            }
            prev.Next= node;
            return;
        }
    }
}
