using System;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;    // ��� ���� (�ʵ�)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int A = AddMethod();    // �Լ� ȣ��
        int B = MinusMethod();  // �Լ� ȣ��
        Debug.Log($"���Ѱ� : {A} / ���� : {B}");
    }

    int AddMethod()
    {
        // ���� ���� result
        int result = number1 + number2;

        return result;
    }
    int MinusMethod()
    {
        // ���� ���� result
        int result = number1 - number2;

        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
