using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int[] arr = new int[2]; 
            arr[100] = 5;
        }
        catch 
        {
            Debug.Log("에러가 발생했습니다");

        }
    }
}

/*
 예외 처리(Exception Handling) : 오류, 에러

//에러, 오류
-문법 오류
-런타임 오류
-알고리즘 오류

에외 처리

try
{
    //명령문...
}

catch
{
    //명령문 실행중 예외(Exception) 발생시 처리할 내용
    //...
} 
 
 
 
 */