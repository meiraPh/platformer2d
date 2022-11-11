using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorTest : MonoBehaviour
{
    
    public Animator animator;

    public KeyCode keyToTrigger = KeyCode.A;
    public KeyCode ketToExit = KeyCode.S;
    public string triggerToPlay = "Fly";

    void Update()
    {
        if(Input.GetKeyDown(keyToTrigger)) 
        {
            animator.SetBool(triggerToPlay, !animator.GetBool(triggerToPlay));
        } 
    } 
}
