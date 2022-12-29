using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int damage = 10;

    public Animator animator;
    public string triggerAttack = "Attack";
    public string triggerKill = "Death";

    public HealthBase healthBase;

    public float timeToDestroy = .7f;

    private void Awake()
    {
        if(healthBase != null)
        {
            healthBase.Onkill += OnEnemyKill;
        }
    }

    private void OnEnemyKill()
    {
        healthBase.Onkill -= OnEnemyKill;
        PlayKillAnimation();
        Destroy(gameObject, timeToDestroy);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var health = collision.gameObject.GetComponent<HealthBase>(); 

        if(health != null)
        {
            health.Damage(damage);
            PlayAttackAnimation();
        }
    }

    private void PlayAttackAnimation()
    {
        animator.SetTrigger(triggerAttack);
    }

    private void PlayKillAnimation()
    {
        animator.SetTrigger(triggerKill);
    }

    public void Damage(int Amount)
    {
        healthBase.Damage(Amount);
    }

}