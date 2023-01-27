using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 dir;

    
    void Start()
    {
        rigid= GetComponent<Rigidbody>();
    }

    void Update()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");


        // P = P0 + vt
        transform.position = dir;

        transform.Translate(dir * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 200, 0));
            condition= false;
        }
    }
}
