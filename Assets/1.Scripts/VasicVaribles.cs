using UnityEngine;

public class VasicVaribles : MonoBehaviour
{
    public int gold = 0;                   //������
    public float PlayerHp = 100.0f;        //�Ǽ���
    public string PlayerName = "���ؿ�";   //���ڿ�
    private bool isActive = true;          //����

    private void Start()
    {
        Debug.Log("���� ����"); //����Ƽ ����׿� �޼����� ���
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
            Debug.Log("������ ��� �ִ�");
        }
        else
        {
            Debug.Log("�� ����");
        }
    }
}
