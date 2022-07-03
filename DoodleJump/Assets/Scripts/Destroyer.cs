using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private GameObject platformPrefab;
    [SerializeField] private GameObject springPrefab;
    [SerializeField] private GameObject BKPlatformPrefab;
    [SerializeField] private float rangeX;
    [SerializeField] private float platformYPos;
    [SerializeField] private float BKPlatformYPos;
    [SerializeField] private float springYPos;

    private GameOverScreen gameOverScreen;

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
            SpawnBKPlatform();
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
        Vector3 position = new Vector2(Random.Range(-rangeX, rangeX), springYPos);
        Instantiate(springPrefab, position, Quaternion.identity);
        springYPos += Random.Range(10, 30);
    }

    private void SpawnBKPlatform()
    {
        BKPlatformYPos = platformYPos;
        BKPlatformYPos += Random.Range(1, 4);
        Vector3 position = new Vector2(Random.Range(-rangeX, rangeX), BKPlatformYPos);
        Instantiate(BKPlatformPrefab, position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if Camera goes up, destroy old platforms and spawn a new things.
        
        if(collision.CompareTag("Platform"))
        {
            SpawnPlatform();
        }

        else if (collision.CompareTag("Spring"))
        {
            SpawnSpring();
        }

        else if(collision.CompareTag("BKPlatform"))
        {
            SpawnBKPlatform();
        }

        Destroy(collision.gameObject);
    }
}
