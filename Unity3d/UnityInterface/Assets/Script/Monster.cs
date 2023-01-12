using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // ���� �ֱ�
    // "MonoBehaviour" Scene1���� ��ư��� ����
    // ������ �帧�� �����, ����Ƽ �������� �ڵ����� ȣ�����ִ� �Լ��Դϴ�.

    int health = 100;

    // Awake()
    // ���ӿ�����Ʈ�� ������ �� ���� ó������ ȣ��Ǵ� �Լ���
    // �� �� ���� ȣ��˴ϴ�.
    private void Awake()
    {
        Debug.Log("Awake() ȣ��");
    }

    // OnEnable()
    // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �Լ��Դϴ�.
    private void OnEnable()
    {
        Debug.Log("OnEnable() ȣ��");
    }

    // Start()
    // ���� ������Ʈ�� �ν��Ͻ��� Ȱ��ȭ�Ǹ� ù ��° �������� ������Ʈ ����
    // �� �� �� ��ȣ��Ǵ� �Լ��Դϴ�.
    void Start()
    {
        Debug.Log("Start() ȣ��");
    }

    // Fixed Update
    // TimeStep�� ������ ���� ���� (0.02)
    // ������ �ֱ�� �� �����Ӹ��� ȣ��Ǵ� �Լ��Դϴ�.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate() ȣ��");
    }

    // Update
    // �� �����Ӹ��� ȣ��Ǵ� �Լ��Դϴ�.
    // ��� ���ɿ� ���� �������� �޶��� �� �ֽ��ϴ�.
    void Update()
    {
        Debug.Log("Update() ȣ��");
    }

    // Late Update
    // Update()�Լ� �Ŀ� �����Ӹ��� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void LateUpdate()
    {
        Debug.Log("LateUpdate() ȣ��");
    }

    // OnDisable
    // ���� ������Ʈ�� ��Ȱ��ȭ�� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void OnDisable()
    {
        Debug.Log("OnDisable() ȣ��");
    }

    // OnDestroy
    // ���� ������Ʈ�� �ı��Ǿ��� �� �� �� ���� ȣ��Ǵ� �Լ��Դϴ�.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy() ȣ��");
    }
}
