using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu]
public class SOPlayerSetup : ScriptableObject
{
    public Animator player;
    public SOString soStringName;
    
    //Header Speed
    [Header("Speed Setup")]
    public Vector2 friction = new Vector2 (.1f, 0);
    public float speed;
    public float speedRun;
    public float forceJump = 2;

    //Header Animation
    [Header("Animation Setup")]
    public float soJumpScaleY;
    public float soJumpScaleX;
    public float soAnimationDuration;

    public Ease ease = Ease.OutBack;

    //Header Animation Player
    [Header("Animation Player")]
    public string boolRun = "Run";
    public string triggerDeath = "Death";
    public float durationSwipePlayer = .1f;
    //public float durationSwipePlayer = .1f;
}
