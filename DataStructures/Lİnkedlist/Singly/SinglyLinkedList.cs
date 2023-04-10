using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist.Singly
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T>? Head { get; set; }
        public int Count { get; set; }
        public SinglyLinkedList()
        {

        }
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
        public void AddBefore(SinglyLinkedListNode<T> node , T item)
        {
            if(Head == null)
            {
                AddFirst(item);
                return;
            }
            var newnode = new SinglyLinkedListNode<T>(item);
            var current = Head;
            var prev = current;
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newnode.Next = prev.Next;
                    prev.Next = newnode;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("The node could not be found int the linked list.");

        }
        public void AddAfter(SinglyLinkedListNode<T> node , T item)
        {
            if (Head == null)
            {
                AddFirst(item);
                return;
            }
            var newnode = new SinglyLinkedListNode<T>(item);
            var current = Head;
            
            while (current != null)
            {
                if (current.Equals(node))
                {
                    newnode.Next = current.Next;
                    current.Next = newnode;
                    return;
                }
                
                current = current.Next;
            }
            throw new Exception("The node could not be found int the linked list.");


        }
        public T RemoveFirst()
        {
            if (Head == null)
            {
                throw new Exception("The node could not be found int the linked list.");
            }
            if (Head.Next==null)
            {
                var item = Head.Value;
                Head = null;
                return item;
            }
            else
            {
                var item = Head.Value;
                Head =Head.Next;
                return item;
            }
        }
        public T RemoveLast()
        {
            if (Head == null)
            {
                throw new Exception("The node could not be found int the linked list.");
            }
            if (Head.Next == null)
            {
                var item = Head.Value;
                Head = null;
                return item;
            }
            else
            {
                var current = Head;
                while (current!=null)
                {
                    if (current.Next.Next==null)
                    {
                        var item = current.Next.Value;
                        current.Next = null;
                        return item;
                    }
                    current = current.Next;
                }
                throw new Exception();
            }
        }
        public T Remove(SinglyLinkedListNode<T> node)
        {
            if (Head == null)
            {
                throw new Exception("The node could not be found int the linked list.");
            }
            else if (Head.Value.Equals(node.Value))
            {
                var item = Head.Value;
                Head = null;
                return item;
            }
            else
            {
                var current = Head;
                while (current!=null) 
                {
                    if (current.Next.Value.Equals(node.Value))
                    {
                        var item = current.Next.Value;
                        current.Next = current.Next.Next;
                        return item;
                    }
                    current = current.Next;
                }
                throw new Exception();
            }

        }

    }
}
