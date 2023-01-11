using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayHelper : MonoBehaviour
{
    public KeyCode keycode = KeyCode.P;
    public AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keycode))
        {
            Play();
        }
    }

    public void Play()
    {
        audioSource.Play();
    }
}
