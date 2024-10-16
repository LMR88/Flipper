using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreText;

    [SerializeField] public int score;

    public static ScoreManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddPoints(int points)
    {
        score += points;
        RefreshText();
    }

    public void RefreshText()
    {
        scoreText.text = "Score : " + score.ToString();
    }
}
