using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    public void RobotHipHopDance()
    {
        animator.Play("Robot Hip Hop Dance");
    }

    public void WaveHipHopDance()
    {
        animator.Play("Wave Hip Hop Dance");
    }

}
