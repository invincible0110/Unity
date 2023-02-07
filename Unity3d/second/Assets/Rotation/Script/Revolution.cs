using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolution : MonoBehaviour
{
    public GameObject moon;
    public GameObject origin;
    public float speed = 1.0f;

    void Start()
    {
        StartCoroutine(RotateCoroutine());
    }
    IEnumerator RotateCoroutine()
    {
        while(true) 
        {
            transform.RotateAround
            (
                origin.transform.position,
                Vector3.down,
                speed * Time.deltaTime
            );

            moon.transform.Rotate(0.1f, 0.1f, 0.1f);

            // yield return null은 자주 사용하는 함수인 Update()가 끝나면
            // 그때 yield return null구문의 밑의 부분이 실행됩니다.
            yield return null;
        }
    }

}
