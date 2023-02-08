using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    
    void Update()
    {
                                      // -10
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * 10;

        // Mathf.Clamp 특정한 값을 제한하는 함수입니다.

        mainCamera.fieldOfView = Mathf.Clamp
            (
                mainCamera.fieldOfView,
                20.0f,
                60.0f
            );

        mainCamera.fieldOfView += distance;
    }
}
