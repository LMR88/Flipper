using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreText;

    [SerializeField] public TMP_Text scoreText2;
    
    [SerializeField] public TMP_Text scoreoverText;

    [SerializeField] public TMP_Text scoreoverText2;

    [SerializeField] public int score;

    [SerializeField] public int score2;

    public static ScoreManager instance;

    public bool player1Targeted;

    private void Awake()
    {
        instance = this;
    }

    public void AddPoints(int points)
    {
        if (player1Targeted)
        {
            score += points;
            RefreshText();
        }
        else
        {
            score2 += points;
            TextRefresh();
        }


    }

    public void RefreshText()
    {
        scoreText.text = "Joueur 1 score : " + score.ToString();
        scoreoverText.text = "Joueur 1 score : " + score.ToString();
    }

    public void TextRefresh()
    {
        scoreText2.text = "Joueur 2 score : " + score2.ToString();
        scoreoverText2.text = "Joueur 2 score : " + score2.ToString();
    }
}
