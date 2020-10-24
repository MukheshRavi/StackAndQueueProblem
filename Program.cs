using System;

namespace StackQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///creating object for stack class
            StackClass<int> stackClass = new StackClass<int>();
            stackClass.Push(70);
            stackClass.Push(30);
            stackClass.Push(56);
            ///Displaying stack
            stackClass.Display();
            ///Pops all elements
            stackClass.PopAll();
            stackClass.Display();
           
        }
    }
}
