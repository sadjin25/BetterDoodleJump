using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKPlatform : MonoBehaviour
{
    [SerializeField] private Score scoreSystem;

    private bool isTouched = false;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Destroy(this.gameObject);

            if (!isTouched)
            {
                isTouched = true;
                scoreSystem.AddScore(-100);
            }
        }
    }
}
