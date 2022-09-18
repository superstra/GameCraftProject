using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;



    // Update is called once per frame
    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x > 0) {
            animator.SetInteger("Direction", 0);
        } else if (movement.x < 0) {
            animator.SetInteger("Direction", 1);
        } else if (movement.y > 0) {
            animator.SetInteger("Direction", 2);
        } else if (movement.y < 0) {
            animator.SetInteger("Direction", 3);
        }
    }

     // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        // gets position + adds a movement * multiplied by the speed * smooth movement modifier
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
