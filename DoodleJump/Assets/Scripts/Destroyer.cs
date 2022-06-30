using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private GameObject springPrefab;
    [SerializeField] private float levelWidth;
    [SerializeField] private float rangeX;
    [SerializeField] private float platformYPos;
    [SerializeField] private float springYPos;

    void Start()
    {
        // Beggining with few Platforms.
        for (int i = 0; i < 6; i++)
        {
            SpawnPlatform();
        }

        for (int i = 0; i < 2; i++)
        {
            SpawnSpring();
        }
    }

    private void SpawnPlatform()
    {
        Vector3 position = new Vector2(Random.Range(-rangeX, rangeX), platformYPos);
        Instantiate(platformPrefab, position, Quaternion.identity);
        platformYPos += Random.Range(2, 3);
    }

    private void SpawnSpring()
    {
        Vector3 position = new Vector2(Random.Range(-levelWidth, levelWidth), springYPos);
        springYPos += Random.Range(10, 30);
        Instantiate(springPrefab, position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Platform"))
        {
            // if Camera goes up, destroy old platforms and spawn a new things.
            SpawnPlatform();
            Destroy(collision.gameObject);
        }

        else if (collision.CompareTag("Spring"))
        {
            SpawnSpring();
            Destroy(collision.gameObject);
        }

        else if(collision.CompareTag("Player"))
        {
            // Game Over
            Destroy(collision.gameObject);
        }
    }
}
