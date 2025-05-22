using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int addResult = AddMethod();
        int subtractResult = SubtractMethod();

        Debug.Log($"Addition Result: {addResult}");
        Debug.Log($"Subtraction Result: {subtractResult}");
    }

    public int AddMethod()
    {
        return num1 + num2;
    }

    public int SubtractMethod()
    {
        return num1 - num2;
    }
}
