using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baseline.ImTools;

namespace DataStructureDay14
{
    public class Stack
    {
        Node top;
        public Stack()
        {
            this.top = null;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", value);
        }
        public void Display()
        {
            if (top == null)
            {
                Console.Write("Stack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data);

                    temp = temp.next;
                    if (temp != null)
                        Console.Write(" -> ");
                }
            }
        }
            public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow!!");
                return;
            }

            Console.WriteLine("Item popped is {0}", top.data);
            top = top.next;
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Underflow!!");
                return;
            }

            Console.WriteLine("{0} is on the top of Stack", this.top.data);
        }
    }
}
