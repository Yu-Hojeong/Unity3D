using UnityEngine;

public class StaticArray : MonoBehaviour
{
    public int[] array1; // 배열 선언
    public int[] array2 = { 10, 20, 30, 40, 50 }; // 배열 선언 후 초기화
    public int[] array3 = new int[5]; // 배열 선언 후 공간만 할당
    public int[] array4 = new int[5] { 10, 20, 30, 40, 50 }; //공간 할당과 초기화
    NewData[] data = new NewData[5];


    public class NewData
    {

    }
}

// void Start()
    // {
    //     array1 = new int[5];
    // }