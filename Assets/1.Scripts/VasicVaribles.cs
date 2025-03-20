using UnityEngine;

public class VasicVaribles : MonoBehaviour
{
    public int gold = 0;                   //정수형
    public float PlayerHp = 100.0f;        //실수형
    public string PlayerName = "김준우";   //문자열
    private bool isActive = true;          //논리형

    private void Start()
    {
        Debug.Log("게임 시작"); //유니티 디버그에 메세지를 출력
    }

    private void Update()
    {
        
    }

    private void HandleMovement(Vector3 direction)
    {
        transform.Translate(direction * Time.deltaTime);
    }


    public void Byeitem()
    {
        if (gold > 50)
        {
            Debug.Log("아이템 살수 있다");
        }
        else
        {
            Debug.Log("돈 없음");
        }
    }
}
