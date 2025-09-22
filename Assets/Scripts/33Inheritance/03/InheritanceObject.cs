using UnityEngine;
using InheritanceObjectTest;

namespace Inheritance
{
    public class InheritanceObject : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //부모클래스의 인스턴스(객체) 생성
            Parent pa = new Parent();
            //pa.Hi();
            Debug.Log(pa.ToString());

            //자식 클래스의 인스턴스(객체) 생성
            Child ch = new Child();
            Debug.Log(ch.ToString());

            //static메서드 : (클래스 이름).매서드이름
            Parent.Hi();

            Child.Hi();
            Child.Hello();


        }
    }
}