using UnityEngine;

namespace Genenric
{
    //제네릭 클래스 선언: 필드, 메서드 활용 
    public class Hello<T>
    {
        //[1] 필드
        private T message;

        //[2] 생성자 - 필드 초기화
        public Hello() 
        {
            //필드 초기화
            message = default(T);
        }
        //매개변수로 T타입의 값을 입력받아 필드 초기화
        public Hello(T _message) 
        {
            this.message = _message;
        }

        //메서드
        public void Say(T msg) 
        {
            Debug.Log(msg);
        }

        public T GetMessage() 
        {
            return this.message;
        }


    }
}