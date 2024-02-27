using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleAnim : MonoBehaviour
{
    public Animator bearIdle;

    void Start()
    {
        StartCoroutine(PlayAnimationRoutine());
    }

    IEnumerator PlayAnimationRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(6f);
            bearIdle.SetTrigger("PlayIdle");
        }
    }
}
