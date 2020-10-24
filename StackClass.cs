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
        }
}
