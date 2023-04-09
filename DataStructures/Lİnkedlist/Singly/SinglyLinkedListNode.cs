namespace Linkedlist.Singly
{
    public class SinglyLinkedListNode<T>
    {
        public T? Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }
        public override string ToString()
        {
            return $"{Value}";
        }

    }
}