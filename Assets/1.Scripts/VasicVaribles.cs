using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        Debug.Log("게임 진행"); //유니티 디버그에 메세지를 출력
    }
}
