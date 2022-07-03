using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BKPlatform : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Destroy(this.gameObject);
        }
    }
}
