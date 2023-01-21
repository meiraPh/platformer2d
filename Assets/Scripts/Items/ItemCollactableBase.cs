using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollactableBase : MonoBehaviour
{
    public string compareTag = "Player";
    public ParticleSystem particleSystem;
    public float timeToHide = 3;
    public GameObject graphicItem;

    private Collider2D[] colliders;

    private void Awake()
    {
        if(particleSystem != null)
        {
            particleSystem.transform.SetParent(null);
        }
        colliders = GetComponents<Collider2D>();

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag(compareTag))
        {
            Collect();
        }
    }

    private void SetCollidersEnabled(bool enabled)
    {
        if (colliders != null)
        {
            for (int i = 0; i < colliders.Length; ++i)
            {
                colliders[i].enabled = enabled;
            }
        }
    }

    protected virtual void Collect()
    {
        if(graphicItem != null) graphicItem.SetActive(false);
        SetCollidersEnabled(false);
        //Invoke("HideObject", timeToHide);
        OnCollect();
    }

    protected virtual void OnCollect()
    {
        if(particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}
