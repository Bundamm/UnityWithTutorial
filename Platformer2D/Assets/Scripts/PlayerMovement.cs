using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController playerController;
    public Animator animator;

    float horizontalMove = 0f;
    
    public float runSpeed = 40f;
    bool jump = false;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        playerController.WallSlide();
        playerController.WallJump();
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("OnWall", false);
    }

    void FixedUpdate()
    {           
        playerController.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;

    }
}
