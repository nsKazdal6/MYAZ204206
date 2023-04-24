using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist.Singly
{
    public class SinglyLinkedList<T> :IEnumerable<T>
    {
        private int _count = 0;
        public SinglyLinkedListNode<T>? Head { get; set; }
        public int Count => _count;
        public SinglyLinkedList()
        {

        }
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddFirst(item);
            }
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
                _count++;
                return;
            }
            node.Next= Head;
            Head = node;
            _count++;
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
                _count++;
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
            _count++;
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
                    _count++;
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
                    _count++;
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
                _count--;
                return item;
            }
            else
            {
                var item = Head.Value;
                Head =Head.Next;
                _count--;
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
                _count--;
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
                        _count--;
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
                _count--;
                return item;
            }
            else
            {
                var current = Head;
                while (current.Next!=null) 
                {
                    if (current.Next.Value.Equals(node.Value))
                    {
                        var item = current.Next.Value;
                        current.Next = current.Next.Next;
                        _count--;
                        return item;    
                    }
                    current = current.Next;
                }
                throw new Exception("Node not found.");
            }

        }
        public IEnumerator<T> GetEnumerator()
        {
            return new SinglyLinkedListEnumerator<T>(Head);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
