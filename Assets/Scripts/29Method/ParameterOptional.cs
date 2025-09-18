using UnityEngine;

namespace Mehod
{
    public class ParameterOptional : MonoBehaviour
    {
        //선택적 매개변수
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(3, 5));   //3 + 5 = 8
            Debug.Log(Add(3));      //3 + 1 = 4
        }

        //선택적 매개변수
        //매개변수로 받은 두개의 정수의 합을 반환하는 함수
        //매개변수 b값은 생략 가능하다, 생략하면 b값은 1로 연산 된다
        int Add(int a, int b = 1) 
        {
            return a + b;
        }
    }
}