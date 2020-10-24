using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueDemo
{
  public class StackClass<T>
    {
        /// <summary>
        /// creating node to point the top node
        /// </summary>
            public Node<T> top;
            /// <summary>
            /// UC1:
            /// Pushes the specified value.
            /// </summary>
            /// <param name="value">The value.</param>
            public void Push(T value)
            {
               ///creating new node
               Node<T> new_node = new Node<T>(value);
               ///If top is not null then top node will be next of new node
                if (this.top != null)
                    new_node.next = this.top;
                ///else new node will be top
                this.top = new_node;
                Console.WriteLine("Value inserted into the stack " + value);
            }
            /// <summary>
            /// Displays this content of stack.
            /// </summary>
            public void Display()
            {
                Node<T> temp = this.top;
                ///If top is null then stack is empty
                if (temp == null)
                {
                    Console.WriteLine("Stack is empty");
                    return;
                }
                ///Iterates full list and prints elements
                else
                {
                    while (temp != null)
                    {
                        Console.Write(" " + temp.data);
                        temp = temp.next;
                    }
                }
            }
        /// <summary>
        /// Displays the topmost element.
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
                Console.WriteLine("\nNothing to display, stack is empty");
            else
                Console.WriteLine("\nTopmost element: " + top.data);
        }
        /// <summary>
        /// Deletes the topmost element.
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
                Console.WriteLine("\nNothing to pop, the stack is empty");
            Console.WriteLine("\nValue popped is {0}", top.data);
            ///The top will be pointed to next node to delete top node
            this.top = this.top.next;
        }
        /// <summary>
        /// This method pops out all elements till stack is empty
        /// </summary>
        public void PopAll()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
