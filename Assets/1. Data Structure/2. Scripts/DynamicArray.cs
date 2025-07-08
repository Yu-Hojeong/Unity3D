using System;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    object[] array = new object[3];

    void Add(object o)
    {
        int newSize = array.Length * 2;
        var temp = new object[newSize];
        for (int i = 0; i < array.Length; i++)
        {
            temp[i] = array[i];
        }
        array = temp;
        array[array.Length - 1] = o;
    }

}
