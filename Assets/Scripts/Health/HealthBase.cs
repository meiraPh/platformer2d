using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public int startLife = 10;

    public bool DestroyOnKill = false;
    public float delayToKill = 0f;

    private int _currentLife;
    private bool _isDead;

    public FlashColor flashColor;

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
            Kill();
        }

        if( flashColor != null)
        {
            flashColor.Flash();
        }
    }

    public void Kill()
    {
        _isDead = true;

        if(DestroyOnKill)
        {
            Destroy(gameObject, delayToKill);
        }
    }
}
