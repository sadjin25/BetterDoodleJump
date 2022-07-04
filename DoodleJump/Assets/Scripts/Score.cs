using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score < 0) score = 0;    

        scoreText.text = score.ToString();
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
    }
}
