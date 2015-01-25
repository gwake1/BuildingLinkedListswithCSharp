﻿﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode firstNode;
        private SinglyLinkedListNode lastNode = null;
        public SinglyLinkedList()
        {
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            foreach (var item in values)
            {
                AddLast(item.ToString());
            }
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void AddAfter(string existingValue, string value)
        {
            if (firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
                return;
            }
            SinglyLinkedListNode currentNode = firstNode;
            while (currentNode.Value != existingValue)
            {
                currentNode = currentNode.Next;
                if (currentNode.IsLast() && currentNode.Value != existingValue)
                {
                    throw new ArgumentException();
                }
            }
            SinglyLinkedListNode insert = new SinglyLinkedListNode(value);
            insert.Next = currentNode.Next;
            currentNode.Next = insert;
        }
        public void AddFirst(string value)
        {
            if (firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
                return;
            }
            SinglyLinkedListNode addfirstnode = new SinglyLinkedListNode(value);
            addfirstnode.Next = firstNode;
            firstNode = addfirstnode;
        }
        public void AddLast(string value)
        {
            if (firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
            }
            else
            {
                SinglyLinkedListNode currentnode = firstNode;
                while (currentnode.Next != null)
                {
                    currentnode = currentnode.Next;
                }
                currentnode.Next = new SinglyLinkedListNode(value);
            }
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            SinglyLinkedListNode currentnode = firstNode;
            while (index > 0 && currentnode != null)
            {
                index--;
                currentnode = currentnode.Next;
            }
            if (currentnode == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            return currentnode.Value;
        }

        public string First()
        {
            if (firstNode == null)
            {
                return null;
            }
            else
            {
                return firstNode.Value;
            }
        }

        public int IndexOf(string value)
        {
            SinglyLinkedListNode currentNode = firstNode;
            int counter = 0;
            if (firstNode == null)
            {
                return counter = -1;
            }
            while (currentNode.Value != value)
            {
                if (currentNode.Next == null)
                {
                    return counter = -1;
                }
                currentNode = currentNode.Next;
                counter++;
            }
            return counter;
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            if (firstNode == lastNode)
            {
                return null;
            }
            SinglyLinkedListNode currentNode = firstNode;
            while (currentNode.Next != lastNode)
            {
                currentNode = currentNode.Next;
            }
            return currentNode.Value;
        }


        public void Remove(string value)
        {
            throw new NotImplementedException();
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            if (firstNode == null)
            {
                return new string[] { };
            }
            SinglyLinkedListNode currentNode = firstNode;
            List<string> arrayList = new List<string> { };
            while (true)
            {
                arrayList.Add(currentNode.Value);
                if (currentNode.Next == null)
                {
                    break;    
                }
                currentNode = currentNode.Next;
            }
            return arrayList.ToArray<string>();
        }

        public override string ToString()
        {
            if (this.firstNode == null)
            {
                return "{ }";
            }
            SinglyLinkedListNode node = firstNode;
            StringBuilder sb = new StringBuilder("{ \"");
            while (true)
            {
                sb.Append(node.ToString());
                if (node.Next == null)
                {
                    break;
                }
                sb.Append("\", \"");
                node = node.Next;
            }
                sb.Append("\" }");
            return sb.ToString();

        }
    }
}