using System;

namespace List
{
    class Program
    {
        static readonly LinkedList linkedList = new LinkedList();
        static readonly SortedLinkedList<int> sortedLinkedList = new SortedLinkedList<int>();
        public static void DisplayLinkedList()
        {
            Console.WriteLine("**LinkedList**");
            Console.WriteLine("-------------");
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            int value = linkedList.Search(30);
            linkedList.InsertAtParticularPosition(value + 1, 40);
            linkedList.Display();
            int foundKey = linkedList.Search(40);
            linkedList.DeleteAtParticularPosition(foundKey);
            linkedList.Size();
            Console.WriteLine("");
        }
        public static void SortedLinkedList()
        {

            Console.WriteLine("-------------");
            Console.WriteLine("**SortedLinkedList**");
            sortedLinkedList.Add(new SortedNode<int>(70));
            sortedLinkedList.Add(new SortedNode<int>(40));
            sortedLinkedList.Add(new SortedNode<int>(30));
            sortedLinkedList.Add(new SortedNode<int>(56));
            Console.WriteLine("LinkedList Before Sorting");
            sortedLinkedList.DisplaySort();
            sortedLinkedList.SortOrderedList();
            Console.WriteLine("LinkedList After Sorting");
            sortedLinkedList.DisplaySort();
        }
        
        static void Main(string[] args)
        {
            DisplayLinkedList();
            SortedLinkedList();
        }
    }
}
