using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Vector2 move;
    Rigidbody2D rb;
    Animator animator;
    private Vector2 lastDir;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>();
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + move * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(move != Vector2.zero) {
            animator.SetFloat("Horizontal", move.x);
            animator.SetFloat("Vertical", move.y);
            animator.Play("Walk");
            lastDir = move;
        } else {
            animator.SetFloat("Horizontal", lastDir.x);
            animator.SetFloat("Vertical", lastDir.y);
            animator.Play("Idle");
        }

        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        
    }
}
