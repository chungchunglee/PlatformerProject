using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Contoller: MonoBehaviour
{
    private Player_Move movement2D;
    Animator animator;

    private void Awake()
    {
        movement2D = GetComponent<Player_Move>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    { 
        float x = Input.GetAxisRaw("Horizontal");
        if (x == 0)
        {
            animator.SetBool("isWalked", false);
        }
        else
        {
            animator.SetBool("isWalked", true);
        }
        movement2D.Move(x);
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("isJumped", true);
            movement2D.Jump();
        }
        if(Input.GetKey(KeyCode.Space))
        {
            movement2D.isLongJump = true;
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("isJumped", false);
            movement2D.isLongJump = false;
        }
    }
}
