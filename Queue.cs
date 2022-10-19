using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Baseline.ImTools;

namespace DataStructureDay14
{
    public class Queue
    {
        public Node front,rear;
        public Queue()
        {
            this.front = this.rear= null;
        }

        public void enqueue(int key)
        {
            Node temp = new Node(key);

            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }
            this.rear.next = temp;
            this.rear = temp;
        }
        public void dequeue()
        {
            if (this.front == null)
                return;

            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }
        }

    }
}
