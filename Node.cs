using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureDay14
{
    public class Node
    {
        public int key;
        public Node next;

        public Node(int key)
        {
            this.key = key;
            this.next = null;
        }
    }
}
