using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;

    
    void Start()
    {
        rigid= GetComponent<Rigidbody>();
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");


        // P = P0 + vt
        
        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 200, 0));
            condition= false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnCollisionStay(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionExit(Collision collision)
    {
    
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

    private void FixedUpdate()
    {
        // 0.02초마다 실행되면서 Update가 실행되기 전에 실행되는 함수
        rigid.MovePosition
        (
            rigid.position + direction * speed * Time.deltaTime
        );
    }
}
