using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    int[] arrayNum = new int[5] { 1, 2, 3, 4, 5 };
    List<int> listNum = new List<int>();

    int num1 = 1;
    private int num2 = 2;
    public int num3 = 3;

    [SerializeField] private int num4 = 4;
    
    [SerializeField]
    private int num5 = 5;

    void Start()
    {
        listNum.Add(1);
        listNum.Add(2);
        listNum.Add(3);
        listNum.Add(4);
        listNum.Add(5);

        Debug.Log("Array Length: " + listNum.Count);

    }
}
