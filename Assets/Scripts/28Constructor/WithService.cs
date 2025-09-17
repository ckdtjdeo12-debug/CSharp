using UnityEngine;

namespace Constructor
{
    public class WithService
    {
        //필드 선언부
        //읽기 전용 필드
        private readonly string serviceNAme;

        //기본 생성자
        //생성자를 통해서 읽기 전용 필드도 초기화가 가능하다
        public WithService() 
        {
            serviceNAme = "파일";
        }

        public WithService(string service) 
        {
            this.serviceNAme = service;
        }

        //매서드 
        public void Run() 
        {
            Debug.Log($"{serviceNAme}를 실행합니다");
        }

    }



}
