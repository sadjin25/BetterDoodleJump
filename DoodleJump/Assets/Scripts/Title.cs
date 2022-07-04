using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{

    private void Start()
    {
        StopGame();
    }

    private void Update()
    {
        if(Input.anyKeyDown)
        {
            ResumeGame();
            Destroy(this.gameObject);
        }
    }

    private void StopGame()
    {
        Time.timeScale = 0;
    }

    private void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
