using UnityEngine;

namespace Constructor
{
    public class My
    {
        //필드 선언부
        private string name; //이름
        int age;            //나이/ 접근 제한자 생략, private

        //생산자 - 이름과 나이 데이터 값을 매개변수로 받아 초기화
        public My(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        //메서드
        public void PrintMyInfo() 
        {
            Debug.Log($"이름:{this.name}, 나이:{this.age}");

        }

        //My 클래스의 인스턴스 생성
        My my = new My("홍길동", 20);
       
    }
}