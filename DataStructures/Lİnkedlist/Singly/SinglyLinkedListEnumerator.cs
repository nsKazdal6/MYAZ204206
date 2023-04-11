using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace Linkedlist.Singly
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T>? Head { get; set; }
        private SinglyLinkedListNode<T>? Curr { get; set; }

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T>? head)
        {
            Head = head;
            Curr = null;
        }

        public T Current => Curr.Value ;

        object IEnumerator.Current => Current ;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if ( Head == null )
                return false;
            else if (Curr == null)
            {
                Curr = Head;
                return true;
            }
            else if (Curr.Next != null)
            {
                Curr= Curr.Next;    
                return true;
            }
            return false; 
        }

        public void Reset()
        {
            Head = null;
            Curr = null;
        }
    }
}