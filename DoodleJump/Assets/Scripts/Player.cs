using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private Score scoreSystem;

    private float movementSpeed = 6f;

    private float movement = 0f;
    private float inputHorizontal;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }


    private void FixedUpdate()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

        inputHorizontal = Input.GetAxisRaw("Horizontal");

        // Flip the sprite
        if(inputHorizontal > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        if (inputHorizontal < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
