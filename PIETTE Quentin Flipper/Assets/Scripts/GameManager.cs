using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
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

    [FormerlySerializedAs("Heart1")] [SerializeField] private GameObject heart1;
    
    [FormerlySerializedAs("Heart2")] [SerializeField] private GameObject heart2;
    
    [FormerlySerializedAs("Heart3")] [SerializeField] private GameObject heart3;
    
    [FormerlySerializedAs("Heart4")] [SerializeField] private GameObject heart4;
    
    [FormerlySerializedAs("Heart5")] [SerializeField] private GameObject heart5;

    [FormerlySerializedAs("Heart6")] [SerializeField] private GameObject heart6;

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
            heart1.SetActive(false);
        }
        else if (lifeCount == 2)
        {
            heart3.SetActive(false);
            SpawnBall();
        }
        else if (lifeCount == 1)
        {
            heart2.SetActive(false);
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
            heart4.SetActive(false);
        }
        else if (lifeCountInverse == 2)
        {
            heart6.SetActive(false);
            SpawnBall();
        }
        else if (lifeCountInverse == 1)
        {
            heart5.SetActive(false);
            SpawnBall();
        }
    }
    
    void SpawnBall()
    {
        GameObject newBille = Instantiate(ballPrefab, spawnTransform.position, Quaternion.identity,transform);
        newBille.GetComponent<Ball>().RandomInitialVelocity();
    }
}
