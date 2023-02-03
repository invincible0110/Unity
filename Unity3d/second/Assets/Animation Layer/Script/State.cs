using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class State : MonoBehaviour
{
    private Animator animator;
    [SerializeField] Slider HealthGauge;

    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StateLayer(float health)
    {
        HealthGauge.value = health;

        float temporary = 1 - HealthGauge.value;

        animator.SetLayerWeight(animator.GetLayerIndex("Other Layer"), temporary);
    }

    
}
