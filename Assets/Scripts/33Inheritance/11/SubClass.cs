using UnityEngine;

namespace InheritanceFieldTest
{
    //자식 클래스
    public class SubClass
    {
        public void SetWord(string _word) 
        {
            base.word = _word;
        }
        public string GetWord() 
        {
            return base.word;
        }
    }
}