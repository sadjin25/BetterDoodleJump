using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    bool isGameOver = false;    

    private void Start()
    {
        gameOverScreen.SetActive(false);    
    }
    private void Update()
    {
        if(isGameOver)
        {
            if (Input.anyKeyDown)
            {
                Restart();
            }
        }

        if (GameObject.FindGameObjectWithTag("Player") == null) 
        {
            gameOverScreen.SetActive(true);
            isGameOver = true;  
        }

    }
    

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
