using UnityEngine;

public class StudyString : MonoBehaviour
{
    public string str1 = "Hello";
    public string[] str2 = new string[3] { "Hello", "Unity", "World" };

    void Start()
    {
        Debug.Log(str1[0]);//H
        Debug.Log(str1[2]);//l
        Debug.Log(str2[0]);//Hello
        Debug.Log(str2[2]);//World
        Debug.Log(str1.Length);//11
        Debug.Log(str1.Trim());//앞뒤공백제거


        Debug.Log(str1.Contains('H'));
        Debug.Log(str1.Contains('h'));
        Debug.Log(str1.Contains("Hello"));

        Debug.Log(str1.ToUpper());
        Debug.Log(str1.ToLower());

        string text = "Apple,Banana,Orange";
        string[] fruits = text.Split(',');
        foreach (var fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }
}
