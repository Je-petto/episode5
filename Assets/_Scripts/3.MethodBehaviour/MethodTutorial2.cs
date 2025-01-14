using Unity.VisualScripting;
using UnityEngine;

public class MethodTutorial2 : MonoBehaviour
{
    
    
    
    public MethodTutorial1 mt;

    int volume;
    string myname;
    
    
    public int A , B; 

    
    void Start()
    {
        int temp = mt.Add(A,B);

        Debug.Log(temp);

    }


    //Add라는 메소드를 MethodTutorial1에 만들고
    //MethodTutorial2에 멤버변수 A, B를 만들고
    //Add Method를 활용하여 로그로 출력
    
}
