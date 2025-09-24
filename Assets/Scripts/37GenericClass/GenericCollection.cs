using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace Genenric
{
    public class Person
    {
        public string Name { get; set; }
        //...
    }



    public class GenericCollection : MonoBehaviour
    {
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        //고객<전용> 리스트 선언 및 초기화
        List<Person> people = new List<Person>
            {
                new Person { Name = " 홍길동"},
                new Person { Name = "백두산" },
                new Person { Name = "임꺽정" },
            };

            //리스트 사용
            foreach (var person in people) 
            {
                Debug.Log(person.Name);
            }
        }
    }
}