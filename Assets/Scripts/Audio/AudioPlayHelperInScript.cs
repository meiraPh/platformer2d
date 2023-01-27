using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayHelperInScript : MonoBehaviour
{
    public string tagToCompare = "Player";
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag(tagToCompare))
        {
            toPlay();
        }
    }
    public void toPlay()
    {
        audioSource.Play();
    }
}
