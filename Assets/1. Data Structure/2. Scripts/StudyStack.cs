using System.Collections.Generic;
using UnityEngine;

public class StudyStack : MonoBehaviour
{
    public Stack<int> stack1 = new Stack<int>();

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            stack1.Push(i);
        }

        Debug.Log(stack1.Pop());
        Debug.Log(stack1.Count);
        Debug.Log(stack1.Peek());
        Debug.Log(stack1.Count);
        Debug.Log(stack1.Pop());
        Debug.Log(stack1.Count);
    }
}
