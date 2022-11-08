using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorTest : MonoBehaviour
{
    
    public Animator animator;

    public KeyCode keyToTrigger = KeyCode.A;
    public string triggerToPlay = "Fly";
    void Update()
    {
        if(Input.GetKeyDown(keyToTrigger)) 
        {
            animator.SetTrigger(triggerToPlay);
        }  
    }
}
