using System.Collections.Generic;
using UnityEngine;

public class StudyLinkedList : MonoBehaviour
{
    public LinkedList<int> linkedlist1 = new LinkedList<int>();
    LinkedListNode<int> node2;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            linkedlist1.AddLast(1);
        }
        linkedlist1.AddFirst(100);
        linkedlist1.AddLast(100);


        var node = linkedlist1.AddFirst(1);
        linkedlist1.AddBefore(node, 200);
        linkedlist1.AddAfter(node2, 100);
    }
}
