using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationControl : MonoBehaviour
{
    [SerializeField] Text speedText;
    [SerializeField] DataSystem data;
    [SerializeField] Animator[] animator;

    public void  SpeedSetting()
    {
        if(data.speed++ >= 10)
        {
            data.speed = 1;
        }

        data.Save();
        speedText.text = data.speed.ToString();

        for(int i = 0; i < animator.Length; i++)
        {
            animator[i].speed = data.speed / 10;
        }
    }
}
