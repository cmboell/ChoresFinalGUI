using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoresFinalGUI
{
    public class PriorityQueue
    {
        //variables
        public Node n;
        public int length;

        //declaring node class
        public class Node
        {
            //variables
            public string chore;
            public double hours;
            public char priorityLevel;
            public int priority;
            public Node next;
            //constructor
            public Node(string chore, double hours, char priorityLevel)
            {
                this.chore = chore;
                this.hours = hours;
                this.priorityLevel = priorityLevel;
                this.priority = priorityLevel;
                this.next = null;
            }
        }

        //constructor
        public PriorityQueue()
        {
            this.n = null;
            this.length = 0;
        }
        //methods
        //create node
        public Node creatNode(string chore, double hours, char priorityLevel)
        {
            Node create = new Node(chore, hours, priorityLevel);
            return create;
        }
        //add
        public void enqueue(string chore, double hours, char priorityLevel)
        {
            if (this.length == 0) //checks to see if queue is empty
            {
                n = creatNode(chore, hours, priorityLevel);
                this.length = 1;
            }
            else
            {
                Node n2 = creatNode(chore, hours, priorityLevel);
                Node n3 = this.n;
                int nodeLength = length;
                Node previous = null;

                while (nodeLength > 0)   //checks priorityLevel levels
                {
                    if ((n3.priority < n2.priority) && (n3.priority != n2.priority))
                    {
                        if (n3.next == null)
                        {
                            n3.next = n2;
                            nodeLength = 0;
                        }
                        else
                        {
                            previous = n3;
                            n3 = n3.next;
                        }
                    }
                    else if (n3.priority == n2.priority)
                    {
                        if (n3.next != null)
                        {
                            previous = n3;
                            n3 = n3.next;
                        }
                        else
                        {
                            previous = n3;
                            n3.next = n2;
                            nodeLength = 0;
                        }

                    }
                    else
                    {
                        if (previous == null)
                        {
                            Node temp = n3;
                            n2.next = n3;
                            nodeLength = 0;
                            this.n = n2;
                        }
                        else
                        {
                            n2.next = n3;
                            previous.next = n2;
                            this.n = previous;
                            nodeLength = 0;
                        }
                    }
                }
                this.length = this.length + 1;
            }
        }

        // Function to print the Values
        public String printQueue()
        {
            String output = String.Empty;
            int nodeLength = this.length;
            Node temp = this.n;
            while (nodeLength > 0)
            {
                
                output += "Chore " + temp.chore + " |Hours To Complete: " + temp.hours + " |Priority: " + temp.priorityLevel;
                nodeLength = nodeLength - 1;
                temp = temp.next;
            }
            return output;
        }

        public int queueSize()
        {
            return this.length;
        }

        public bool isQueueEmpty()
        {
            return this.length == 0;
        }
    }
}