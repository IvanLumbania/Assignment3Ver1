using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    public class Node
    {
        private object element;
     private Node next;

     public Node(object o)
     {
         this.Element = o;
     }

     public Node(object o, Node n)
     {
         this.Element = o;
         this.Next = n;
     }

     public object Element { get => element; set => element = value; }
     public Node Next { get => next; set => next = value; }
    }
    
}
