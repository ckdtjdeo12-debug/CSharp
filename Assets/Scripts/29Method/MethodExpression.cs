using Unity.VisualScripting;
using UnityEngine;

namespace Method
{
    //메서드 축약형

    public class MethodExpression : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();

            Debug.Log(DubleValue(4));   //8
            Debug.Log(Sum(4, 4));      //8
        }

        //함수 기본형식
        void Work() 
        {
            Debug.Log("Work!!!");
            
        }

        //축약형
        void Hello() => Debug.Log("Hello");

        //매개변수로 받은 정수값을 두배로 반환하는 메서드
        int DubleValue(int value) => value * 2;

        //매개변수로 입력빋은 두개의 정수의 값을 합을 반환하는 메서드
        int Sum(int a, int b) => a + b;


    }
}