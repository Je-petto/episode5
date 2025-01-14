using System;
using NUnit.Framework.Interfaces;
using Unity.VisualScripting;
using UnityEngine;

public class MethodTutorial1 : MonoBehaviour
{
    
    private void Start()
    {
    
    }

    int volume = 10;
    public int volume2;

    // Method 선언 - 실행을 위해서는 Start에 기입
    public void Method1(/*input, 파라미터 */)
    {
        // 지역(Local) 변수
       
        //Debug.Log(volume);

    }

    //Method1에 있는 volume을 사용할 수 없는 이유 = 지역 변수이기 때문에 지역 변수는 Method 안에 있는 것만 취급 가능
    //이를 위해서는 Method에서 빼 멤버 변수로 변수 전환을 해야 한다 - Method 밖으로 빼면 됌
    void Method2()
    {
        //Debug.Log(volume);
    }

    //메소드 선언 작업
    public int Add(int a, int b)
    {
        return a + b;
    }


}
