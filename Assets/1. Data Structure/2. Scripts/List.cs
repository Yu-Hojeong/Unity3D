using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<int> list1 = new List<int>();
    public List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };
    public List<int> list3;


    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            list1.Add(i);
        }
        // list1.Insert(5, 100); // 5번에 100의 값을 넣음
        // list1.Remove(5); //5라는 값을 지움
        // list1.RemoveAt(5);//5번 값을 지움
        // list1.RemoveRange(1, 3);//1번부터 3개까지 지움
        list1.RemoveAll(x => x > 5);
    }
    

}
