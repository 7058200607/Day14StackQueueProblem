﻿using StackQueueProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14StackQueueProblem
{
    public class LinkList
    {
        Node head = null;
        internal void EnQueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;

            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into Queue", node.data);
            }
        }
        internal void display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }

}
