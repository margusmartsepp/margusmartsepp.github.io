using System;
using System.Collections.Generic;

namespace SearchingAlgorithms
{
    public static class SublistSearch
    {
        public static bool IsSublist(LinkedList<int> mainList, LinkedList<int> subList)
        {
            LinkedListNode<int> mainListNode = mainList.First;
            LinkedListNode<int> subListNode = subList.First;

            while (mainListNode != null)
            {
                LinkedListNode<int> tempMainNode = mainListNode;

                while (subListNode != null)
                {
                    if (tempMainNode == null || tempMainNode.Value != subListNode.Value)
                    {
                        break;
                    }

                    tempMainNode = tempMainNode.Next;
                    subListNode = subListNode.Next;
                }

                if (subListNode == null)
                {
                    return true;
                }

                subListNode = subList.First;
                mainListNode = mainListNode.Next;
            }

            return false;
        }
    }
}
