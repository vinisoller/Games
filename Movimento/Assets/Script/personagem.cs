using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour
{

    public float Speed;
    public float JumpForce;

    private Rigidbody2D rig;

    public bool IsJumping;

    public Animator animator;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        move();
        Jump();

        if (Input.GetAxis("Horizontal") != 0)
        {
            //esta correndo
            animator.SetBool("taCorrendo", true);
        }
        else
        {
            //esta parado
            animator.SetBool("taCorrendo", false);
        }
    }

    void move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Speed;

        float inputAxis = Input.GetAxis("Horizontal");

        if (inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
        }

        if (inputAxis < 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
        }

    }
    
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && !IsJumping)
        {
            rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        }
    }
}
