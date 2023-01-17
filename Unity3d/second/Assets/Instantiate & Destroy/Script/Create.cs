using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject prefab; // 생성할 게임 오브젝트
    public Transform[] randomPosition;
    
    public void GenericCreate()
    {
        Delay.action();

        Instantiate
        (
            prefab, // 게임 오브젝트
            randomPosition[Random.Range(0,4)].position, // 생성되는 오브젝트의 위치
            Quaternion.identity // 생성되는 오브젝트의 회전
                                // Quaternion.identity : 게임 오브젝트를 회전시키지 않겠다.
        );
    }
    
}
