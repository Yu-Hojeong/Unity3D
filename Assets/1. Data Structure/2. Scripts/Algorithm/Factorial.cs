using UnityEngine;

public class Factorial : MonoBehaviour
{
    void Start()
    {
        FactorialFunction(5);
    }

    private int FactorialFunction(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * FactorialFunction(n-1);
    }
}
