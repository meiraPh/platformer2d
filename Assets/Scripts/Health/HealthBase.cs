using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public Action Onkill;
    
    public int startLife = 10;

    public bool DestroyOnKill = false;
    public float delayToKill = 0f;

    private int _currentLife;
    private bool _isDead;

    [SerializeField]
    private FlashColor flashColor;

    private void Awake()
    {
        Init();
        if( flashColor == null)
        {
            flashColor = GetComponent<FlashColor>();
        }
    }

    private void Init()
    {
        _isDead = false;
        _currentLife = startLife;
    }

    public void Damage(int damage)
    {
        if (_isDead) return;
        
        _currentLife -= damage;

        if(_currentLife <= 0)
        {
            flashColor.StopFlashColor();
            Kill();
        }

        else
        {
            if( flashColor != null)
            {
                flashColor.Flash();
            }
        }
    }

    public void Kill()
    {
        _isDead = true;

        if(DestroyOnKill)
        {
            Destroy(gameObject, delayToKill);

        }

        Onkill?.Invoke();
    }
}
