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
        /// Dequeue element from queue
        /// </summary>
        public void Dequeue()
        {
            // If queue is empty returns NULL.  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous head and move head pointer one step ahead to delete the current element 
            Node<T> temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }
        /// <summary>
        /// Removes all elements
        /// </summary>
        public void DeQueueAll()
        {
            ///Removes all elements till queue is null
            while (head != null)
                Dequeue();
        }
        /// <summary>
        /// Displays Whole queue
        /// </summary>
        public void Display()
        {
            Node<T> temp = this.head;
            ///If head is null then queue is empty
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            ///If head is not null then it displays whole queue
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
