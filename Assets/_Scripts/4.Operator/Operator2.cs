using UnityEngine;

public class Operator2 : MonoBehaviour
{
    [Header("BMI")]
    public float weight;
    public float height;

    
    [Header("입력창")]
    public bool A;
    public bool B;
    public int nC;
    
    [Header("결과창")]
    [ReadOnly] public bool opSame;
    [ReadOnly] public bool opDiff;
    [ReadOnly] public bool opGreater;

    // A = B B의 값을 A에 넣어라
    // A == B A 와 B가 같습니까? 
    
    void Start()
    {
        isBMI(weight,height);

        Debug.Log(isBMI(weight,height));

    }
    
    void Update()
    {
       bool isSame = A == B;
       bool isDiff = A != B;
       bool isGreater = nC > 10;

       opSame = isSame;
       opDiff = isDiff;
       opGreater = isGreater;


       
    }

    string isBMI(float w, float h)
    {
        float result = w / (h * h);

        string bmiresult = result >= 20 ? "과체중": "정상";

        return bmiresult;
    }
}
