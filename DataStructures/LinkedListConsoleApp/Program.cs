using Linkedlist.Singly;

var linkedList = new SinglyLinkedList<int>(new SortedSet<int>
{
    5,3,4,2,7
}); 

foreach (var item in linkedList)
{
    Console.WriteLine(item);
}


Console.ReadKey();
