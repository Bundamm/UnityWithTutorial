using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController playerController;
    public Animator animator;
    private bool hasBeenCollected = false;
    public AppleManager appleManager;

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
        animator.SetBool("OnWall", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!hasBeenCollected && other.gameObject.CompareTag("Apple"))
        {
            hasBeenCollected = true;
            Debug.Log("apple");
            Destroy(other.gameObject);
            
        }
    }
    
    void FixedUpdate()
    {           
        playerController.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
        hasBeenCollected = false;
    }
}
