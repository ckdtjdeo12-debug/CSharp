

using System.Diagnostics;

public class HelloWorld : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hello Unity!");
        //Debug.Log("123456789");

        UnityEngine.Debug.Log("Hello Unity!\n123456789");
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// 한줄 주석 : 설명문 

// 여러줄 주석
/* 
 */

/*
[output]

123456789
*/