using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueDemo
{
    class QueueClass<T>
    {
        Node<T> head;
        /// <summary>
        /// UC1
        /// This method is to add a element in queue
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(T item)
        {
            ///If queue is empty then new node will be head
            Node<T> new_node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            ///if queue is not empty then new element will be next of head
            else
            {
                Node<T> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("inserted into list " + new_node.data);
        }
        /// <summary>
        /// Displays Whole queue
        /// </summary>
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
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
