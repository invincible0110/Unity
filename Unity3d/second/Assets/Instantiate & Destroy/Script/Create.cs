using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab; // ������ ���� ������Ʈ
    public Transform[] randomPosition;
    
    public void GenericCreate()
    {
        Delay.action();

        Instantiate
        (
            prefab, // ���� ������Ʈ
            randomPosition[Random.Range(0,4)].position, // �����Ǵ� ������Ʈ�� ��ġ
            Quaternion.identity // �����Ǵ� ������Ʈ�� ȸ��
                                // Quaternion.identity : ���� ������Ʈ�� ȸ����Ű�� �ʰڴ�.
        );
    }
    
}
