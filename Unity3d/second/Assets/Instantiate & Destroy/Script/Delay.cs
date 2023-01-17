using System;
using UnityEngine;
using UnityEngine.UI;

public class Delay : MonoBehaviour
{
    private Button button;
    public static Action action;

    private bool isDelay = true;
    private float fixedTime = 5f;
    private float currentTime = 5f;

    private void Start()
    {
        action = () => isDelay= false; // == action = () => Function();
        button = GetComponent<Button>();
    }
    //void Function()
    //{
    //    isDelay = false;
    //}


    void Update()
    {
        if(isDelay == false) 
        {
            button.interactable= false; // 버튼 비활성화
            currentTime-=Time.deltaTime; 
            button.image.fillAmount = currentTime / fixedTime;
            
            if(currentTime <= 0) 
            {
                isDelay= true;
                button.interactable= true; // 버튼 활성화
                button.image.fillAmount = currentTime = fixedTime;
            }
        }
    }
}

