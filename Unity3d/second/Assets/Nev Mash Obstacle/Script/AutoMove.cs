using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
   
   
    void Update()
    {
        transform.position = new Vector3
        (
            Mathf.PingPong(Time.time, 3),
            transform.position.y,
                transform.position.z
        );
    }
}
