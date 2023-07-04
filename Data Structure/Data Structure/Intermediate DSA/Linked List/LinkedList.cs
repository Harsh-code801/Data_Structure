using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Structure.Intermediate_DSA.Linked_List
{
    internal class LinkedList
    {
        public void ReverseList(int[] arr)
        {
            LinkedListClass linkedListClass = new LinkedListClass();
            for(int i = 0; i < arr.Length; i++)
            {
                linkedListClass.AddNode(new LinkedListClass.Node(arr[i]));
            }
            Console.WriteLine("============================================================");
            Console.WriteLine("Input");
            linkedListClass.PrintNode();
            linkedListClass.ReverseList();
            Console.WriteLine("Reverse List");
            linkedListClass.PrintNode();
            Console.WriteLine("============================================================");
        }
    }
    public class LinkedListClass
    {
        public Node Head;
        public class Node
        {
            public int Data;
            public Node next;
            public Node(int Data)
            {
                this.Data = Data;
                this.next = null;
            }
        }
        public void AddNode(Node node)
        {
            if(Head == null)
                Head = node;
            else
            {
                Node temp = Head;
                while(temp.next != null) { 
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void ReverseList() {
            Node next = null, Current = Head, previous = null;
            while (Current != null) {
                next = Current.next;
                Current.next = previous;
                previous = Current;
                Current = next;
            }
            Head = previous;
        }
        public void PrintNode() {
            Console.WriteLine();
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
