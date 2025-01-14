using NUnit.Framework.Interfaces;
using UnityEngine;

public class ConstantTutorial : MonoBehaviour
{
#region 멤버변수
// region endregion = 영역을 나누어 관리하기 편하게 만들어 줌/책갈피 역할도 함
// (멤버) 변수 영역

    //space를 통해 띄어쓰기/(괄호) 안 숫자를 통해 간격 조정가능
    // [Header("Score")]// [] = Attribute
    // [Space, SerializeField] int score;
    //[SerializeField] int score2;
    public int score1;
    private const int MAX_SCORE = 123;

    [ReadOnly]
    public int score3;


#endregion

#region 상수


#endregion

#region 메소드 (함수)
// (Method) 함수 영역
    public void Start()
    {
        score1 =7;

        // 업데이트에서 score1 -> score3 값을 (전달, 대입, 넣는다)
        


    }
    //int Update()
    //{
        // 지역(Local) 변수
        //score3 = score1;
    //}


#endregion     
}