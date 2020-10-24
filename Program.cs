using System;

namespace StackQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///creating object for stack class
            QueueClass<int> queueClass = new QueueClass<int>();
            queueClass.Enqueue(56);
            queueClass.Enqueue(30);
            queueClass.Enqueue(70);
            ///Displaying Queue elements
            queueClass.Display();
           
           
        }
    }
}
