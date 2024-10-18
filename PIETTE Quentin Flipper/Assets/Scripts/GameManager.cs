using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int ballCount;

    [SerializeField] public int lifeCount = 3;

    public static GameManager instance;

    [SerializeField] public GameObject ballPrefab;

    [SerializeField] private Transform spawnTransform;

    public GameObject gameOverScreen;

     void Awake()
    {
        instance = this;
    }

    public void LoseBall()
    {
        ballCount--;

        if (ballCount == 0)
        {
            lifeCount--;
        }

        if (lifeCount == 0)
        {
            gameOverScreen.SetActive(true);
        }
        else
        {
            SpawnBall();
        }
    }
    
    void SpawnBall()
    {
        Instantiate(ballPrefab, spawnTransform.position, Quaternion.identity,transform);
    }
}
