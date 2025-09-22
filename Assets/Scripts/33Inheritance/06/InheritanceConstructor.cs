using InheritanceConstructorTest;
using UnityEngine;

namespace Inheritance
{
    public class InheritanceConstructor : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //자식 클래스의 인스턴스(객체) 생성
            Child child = new Child();
            child.SayHello();       //안녕하세요 인사

            Child child2 = new Child(); 
            child2.SayHello();      //반갑습니다 인사

        }
    }
}