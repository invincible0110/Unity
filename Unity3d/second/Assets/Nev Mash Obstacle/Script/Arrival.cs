using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Arrival : MonoBehaviour
{
    public Transform arrive; // 목적지 변수 선언
    private NavMeshAgent agent; // NavMash 참조 변수 선언
    
    void Start()
    {
        agent= GetComponent<NavMeshAgent>(); // 참조 변수에 컴포넌트 삽입
    }

    void Update()
    {
        agent.SetDestination(arrive.position); // 목적지 설정
    }
}
