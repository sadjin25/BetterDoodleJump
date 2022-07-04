using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] public Score scoreSystem;
    private float jumpForce = 15f;
    private bool isTouched = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            // if Player is available <--- useless?
            if (rb != null)
            {
                //Cannot change rb's each values(x,y). put entire 'velocity'
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce + (-collision.relativeVelocity.y) * 0.5f;
                rb.velocity = velocity;
                
                if (!isTouched)
                {
                    isTouched = true;
                    scoreSystem.AddScore(300);
                }
            }
        }
    }
}
