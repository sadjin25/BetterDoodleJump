using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    public float jumpForce = 15f;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                //Cannot change rb's each values(x,y). put entire 'velocity'
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce + (-rb.velocity.y) * 0.5f;
                rb.velocity = velocity;
            }
        }
    }
}
