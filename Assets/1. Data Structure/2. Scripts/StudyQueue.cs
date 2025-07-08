using System.Collections.Generic;
using UnityEngine;

public class StudyQueue : MonoBehaviour
{
    public Queue<int> queue = new Queue<int>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
        }

        int output = queue.Dequeue(); //값을 뽑음
        Debug.Log(output);
        Debug.Log(queue.Peek()); //다음 뽑을 값을 확인
        Debug.Log(queue.Contains(5)); //값 5 가 포함되었는지 확인

        queue.Clear();

        Debug.Log(queue.Count);



    }
}
