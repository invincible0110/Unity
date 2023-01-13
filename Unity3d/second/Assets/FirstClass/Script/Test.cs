using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{
    public Monster()
    {
        Debug.Log("Monster�� �¾���ϴ�.");
    }
}
public class Test : MonoBehaviour
{
    public int value = 100;
    public int[] count;
    public int[] data = new int[3];

    void Start()
    {
        Debug.Log(value);
        Monster monster = new Monster();

        transform.position = new Vector3(0, transform.position.y, 1);

        foreach(var element in data)
        {
            Debug.Log(element);
        }
    }

    
    void Update()
    {
        // GetKeyDown : Ű�� ������ ��
        // GetKey : Ű�� ������ ���� ��
        // GetKeyUp : Ű�� ���� ��
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("�����̽� ����");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x-1, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x+1, transform.position.y, transform.position.z);
        }
    }
}
