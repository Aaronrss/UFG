using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public string playerId;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal" + playerId) * runSpeed;
        // animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        animator.SetFloat("Speed", horizontalMove);
        if (horizontalMove != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        if (controller.m_FacingRight)
        {
            animator.SetBool("facingRight", true);
        }
        else if (!controller.m_FacingRight)
        {
            animator.SetBool("facingRight", false);
        }

        if (Input.GetButtonDown("Jump" + playerId))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch" + playerId))
        {
            crouch = true;
            animator.SetBool("IsCrouching", true);
        }
        else if (Input.GetButtonUp("Crouch" + playerId))
        {
            crouch = false;
            animator.SetBool("IsCrouching", false);
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
