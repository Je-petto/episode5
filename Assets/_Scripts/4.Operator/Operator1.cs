using NUnit.Framework.Interfaces;
using UnityEngine;

public class Operator1 : MonoBehaviour
{

    // 연산자(Operator)
    // +: 덧셈
    // -: 뺄샘
    // *: 곱셈
    // /: 나눗셈
    // %: 나머지
    
    [Header("연산값")]
    public float A;
    public float B;
    public float C;

    public bool bA;
    public bool bB;
    public bool bC;

    [Header("연산자결과")]
    //And 연산 결과
    [ReadOnly] public bool andOP;
    [ReadOnly] public bool orOP;
    [ReadOnly] public bool notOP;
    [ReadOnly] public bool ifOP;
    [ReadOnly] public string ifOPstring;


    [Header("연산자결과")]
    public string agestring;
    //public string AA;
    //public string BB;
    [Header("연산값")]
    public float weight;
    public float height;
    



    void Start()
    {
        // % 나머지 연산자로 A, B를 연산하기 -> 로그
        // $연산자 용 메소드를 만든다

        // 5 , 8
        // == ? false
        // != ? true
        // <= ? true
        // >= ? false
        // < ? true
        // > ? false
        
        //float rest = Remaindor(A, B);
        //string result = $"나머지는 {rest}";

        //Debug.Log($"== {AA.Length <= BB.Length}");
        //Debug.Log(A != B);

        // 논리연산
        // && 그리고 (And 연산) : 모두가 참일 때 True
        // ||(Shift + 원화 표시) 또는 (Or) : 둘 중 하나만 참일 때 True
        // ! 아니다 (Not 연산)

        isBMI(weight, height);
    }

        
    public int age = 20;
    public int bmi = 20;

    void Update()
    {
        andOP = (A == B);
        andOP = (A > B);
        andOP = bA && bB && bC;
        andOP = (bA || bB) && bC;

        // 삼항연산 - 항이 세 개인 연산
        ifOP = bA == bB ? true : false;
        ifOPstring = bA == bB ? "bA bB 가 같다" : "bA bB 가 다르다";


        agestring = isAdult(age);
    
        
    }
    
    string isAdult(int ageover)
    {
        return agestring = ageover > 19 ? "성인이다" : "미성년자다";
    }

   
    void isBMI(float w, float h)
    {
        float result =  w / (h * h);
        
        string bmiresult = result >= 20 ? "과체중" : "표준";

        Debug.Log(result >= 20 ? "과체중" : "표준");

        
    }

    

    // bmi 수치 : 몸무게 / 키*키
    // 20 이상 과체중 아니면 표준

    
    

    // 변수와 지역 변수의 이름을 같게 하면 동명이인 충돌로 인해 연산이 되지 않음
    // 다른 이름으로 하기
    float Remaindor(float a, float b)
    {
        return a % b;
    }

    //bool : True, Flase
    //비교 연산
    //bool CompareOp(int a , int b)
    //{
        //a == b
    //}

    
    

}