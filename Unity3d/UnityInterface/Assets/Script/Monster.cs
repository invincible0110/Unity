using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // 생명 주기
    // "MonoBehaviour" Scene1에서 살아가는 동안
    // 일정한 흐름이 생기고, 유니티 엔진에서 자동으로 호출해주는 함수입니다.

    int health = 100;

    // Awake()
    // 게임오브젝트가 생성될 때 가장 처음으로 호출되는 함수로
    // 단 한 번만 호출됩니다.
    private void Awake()
    {
        Debug.Log("Awake() 호출");
    }

    // OnEnable()
    // 게임 오브젝트가 활성화 되었을 때 호출되는 함수입니다.
    private void OnEnable()
    {
        Debug.Log("OnEnable() 호출");
    }

    // Start()
    // 게임 오브젝트의 인스턴스가 활성화되면 첫 번째 프레임의 업데이트 전에
    // 단 한 번 만호출되는 함수입니다.
    void Start()
    {
        Debug.Log("Start() 호출");
    }

    // Fixed Update
    // TimeStep에 설정된 값에 따라 (0.02)
    // 일정한 주기로 매 프레임마다 호출되는 함수입니다.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate() 호출");
    }

    // Update
    // 매 프레임마다 호출되는 함수입니다.
    // 기기 성능에 따라 프레임이 달라질 수 있습니다.
    void Update()
    {
        Debug.Log("Update() 호출");
    }

    // Late Update
    // Update()함수 후에 프레임마다 한 번씩 호출되는 함수입니다.
    private void LateUpdate()
    {
        Debug.Log("LateUpdate() 호출");
    }

    // OnDisable
    // 게임 오브젝트를 비활성화할 때 마다 호출되는 함수입니다.
    private void OnDisable()
    {
        Debug.Log("OnDisable() 호출");
    }

    // OnDestroy
    // 게임 오브젝트가 파괴되었을 때 단 한 번만 호출되는 함수입니다.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy() 호출");
    }
}
