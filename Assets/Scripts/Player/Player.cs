using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    //Header Speed
    [Header("Speed Setup")]
    public Vector2 friction = new Vector2 (.1f, 0);
    public float speed;
    public float speedRun;
    public float forceJump = 2;

    //Header Animation
    [Header("Animation Setup")]
    public float jumpScaleY = 1.5f;
    public float jumpScaleX = 0.7f;
    public float animationDurantion = .3f;
    public Ease ease = Ease.OutBack;

    private float _currentSpeed;
    
    private void Update()
    {
        HandleJump();
        HandleMovement();
    }

    private void HandleMovement()
    {
        if(Input.GetKey(KeyCode.LeftControl))
            _currentSpeed = speedRun;
        else   
            _currentSpeed = speed;

        
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = new Vector2(-_currentSpeed, myRigidbody.velocity.y);
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector2(_currentSpeed, myRigidbody.velocity.y);
        }

        if(myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity += friction;
        }
        else if(myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity -= friction;
        }
    }

    private void HandleJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            myRigidbody.velocity = Vector2.up* forceJump;
            myRigidbody.transform.localScale = Vector2.one;
            DOTween.Kill(myRigidbody.transform);
            HandleScaleJump();
        }
    }

    private void HandleScaleJump()
    {
        myRigidbody.transform.DOScaleY(jumpScaleY, animationDurantion).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        myRigidbody.transform.DOScaleX(jumpScaleX, animationDurantion).SetLoops(2, LoopType.Yoyo).SetEase(ease);
    }
}
