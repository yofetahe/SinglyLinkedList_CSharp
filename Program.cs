using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SLinkedList sll = new SLinkedList();
            sll.Add(1);
            sll.Add(2);
            sll.Add(3);
            sll.Add(4);
            sll.Add(5);

            sll.Reverse();

            System.Console.WriteLine("-----------");
            sll.PrintValues();
            // sll.Remove();
            // System.Console.WriteLine("-----------");
            // sll.PrintValues();
            // System.Console.WriteLine("-----------");
            // System.Console.WriteLine(sll.Find(3));
        }
    }
}
