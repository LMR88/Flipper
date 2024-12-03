using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreText;

    [SerializeField] public TMP_Text scoreText2;
    
    [FormerlySerializedAs("scoreoverText")] [SerializeField] public TMP_Text scoreOverText;

    [FormerlySerializedAs("scoreoverText2")] [SerializeField] public TMP_Text scoreOverText2;

    [SerializeField] public int score;

    [SerializeField] public int score2;

    public static ScoreManager instance;

    public bool player1Targeted;

    [FormerlySerializedAs("Player1Win")] [SerializeField] public GameObject player1Win;
    
    [FormerlySerializedAs("Player2Win")] [SerializeField] public GameObject player2Win;

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

        if (score > score2)
        {
            player1Win.SetActive(true);
            player2Win.SetActive(false);
        }
        else
        {
            player2Win.SetActive(true);
            player1Win.SetActive(false);
        }


    }

    public void RefreshText()
    {
        scoreText.text = "Joueur 1 score : " + score.ToString();
        scoreOverText.text = "Joueur 1 score : " + score.ToString();
    }

    public void TextRefresh()
    {
        scoreText2.text = "Joueur 2 score : " + score2.ToString();
        scoreOverText2.text = "Joueur 2 score : " + score2.ToString();
    }
    
}
