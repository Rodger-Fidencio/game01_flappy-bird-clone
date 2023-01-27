using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class logicScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
        scoreText.text = score.ToString();
    }

    public void addScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();
    }
}
