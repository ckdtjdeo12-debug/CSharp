using UnityEngine;


namespace Consturctor
{
    public class ConstructorOverload : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Constructorlog 클래스의 인스턴스 생성

            //기본 생성자를 호출하여 인스턴스 생성
            ConstructorLog log1 = new ConstructorLog();    
            //매개변수 string이 있는 생성자를 호출하여
            ConstructorLog log2 = new ConstructorLog("홍길동");      
            //매개변수 string이 있는 생성자를 호출하여 다른 인스턴스 생성
            ConstructorLog log3 = new ConstructorLog("백두산");     
        }
    }
}

/*
//생성자 Overload : 함수의 다중 정의
:동일한 이름의 생성자를 매개변수를 달리해서 여러개 생성


 */