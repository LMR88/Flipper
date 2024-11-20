using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public int ballCount;

    [SerializeField] public int lifeCount = 3;
    
    [SerializeField] public int lifeCountInverse = 3;

    public static GameManager instance;

    [SerializeField] public GameObject ballPrefab;

    [SerializeField] private Transform spawnTransform;

    public GameObject gameOverScreen;

    [SerializeField] private GameObject Heart1;
    
    [SerializeField] private GameObject Heart2;
    
    [SerializeField] private GameObject Heart3;
    
    [SerializeField] private GameObject Heart4;
    
    [SerializeField] private GameObject Heart5;

    [SerializeField] private GameObject Heart6;

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
            Heart1.SetActive(false);
        }
        else if (lifeCount == 2)
        {
            Heart3.SetActive(false);
            SpawnBall();
        }
        else if (lifeCount == 1)
        {
            Heart2.SetActive(false);
            SpawnBall();
        }
    }

    public void LoseBallInverse()
    {
        ballCount--;

        if (ballCount == 0)
        {
            lifeCountInverse--;
        }

        if (lifeCountInverse == 0)
        {
            gameOverScreen.SetActive(true);
            Heart4.SetActive(false);
        }
        else if (lifeCountInverse == 2)
        {
            Heart6.SetActive(false);
            SpawnBall();
        }
        else if (lifeCountInverse == 1)
        {
            Heart5.SetActive(false);
            SpawnBall();
        }
    }
    
    void SpawnBall()
    {
        Instantiate(ballPrefab, spawnTransform.position, Quaternion.identity,transform);
    }
}
