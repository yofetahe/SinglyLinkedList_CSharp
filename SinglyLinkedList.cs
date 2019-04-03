using System;


namespace SinglyLinkedList
{

    public class SLinkedList
    {
        public SllNode Head;
        public SLinkedList()
        {
            Head = null;
        }

        public void Add(int value)
        {
            SllNode newNode = new SllNode(value);
            
            if(Head == null){
                Head = newNode;
            } 
            else 
            {
                SllNode runner = Head;
                while(runner.Next != null){
                    runner = runner.Next;
                }
                runner.Next = newNode;   
            }
        }

        public void Remove()
        {
            if(Head == null){
                return;
            } else {
                SllNode runner = Head;
                SllNode runner_next = Head.Next;
                while(runner_next.Next != null){
                    runner = runner_next;
                    runner_next = runner_next.Next;
                }
                System.Console.WriteLine(runner.Value);
                runner.Next = null;
            }
        }

        public void PrintValues()
        {
            SllNode runner = Head;
            while(runner != null){
                System.Console.WriteLine(runner.Value);
                runner = runner.Next;
            }
        }

        public SllNode Find(int value)
        {
            SllNode runner = Head;
            while(runner.Next != null){
                if(runner.Value == value){
                    return runner;
                }
                runner = runner.Next;
            }            
            return null;
        }

        public void RemoveAt(int index)
        {
            SllNode before = null;
            SllNode current = Head;
            SllNode future = Head.Next;
            int counter = 0;
            while(current.Next != null){
                if(counter == index)
                {
                    break;
                }
                before = current;
                current = future;
                future = future.Next;
                counter++;
            }
            before.Next = future;
        }

        public void Reverse()
        {
            SllNode before = null;
            SllNode current = Head;
            SllNode future = Head.Next;
            
            while(future.Next != null){
                
                SllNode temp = future.Next;

                current.Next = before;
                future.Next = current;
                
                before = current;
                current = future;
                future = temp;
            }
            future.Next = current;
            Head = future;
        }
    }
}