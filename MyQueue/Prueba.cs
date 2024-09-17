using System;

namespace MyQueue
{
    public class Prueba
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST QUEUE");

            MyQueue<String> myQueue = new MyQueue<string>();
            myQueue.Enqueue("A");
            
            
            Console.WriteLine(myQueue.IsEmpty());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Peek());
        }
    }
}