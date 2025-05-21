using System;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;    // 멤버 변수 (필드)
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int A = AddMethod();    // 함수 호출
        int B = MinusMethod();  // 함수 호출
        Debug.Log($"더한값 : {A} / 뺀값 : {B}");
    }

    int AddMethod()
    {
        // 지역 변수 result
        int result = number1 + number2;

        return result;
    }
    int MinusMethod()
    {
        // 지역 변수 result
        int result = number1 - number2;

        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
