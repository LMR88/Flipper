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

    [SerializeField] private GameObject Heart1;
    
    [SerializeField] private GameObject Heart2;
    
    [SerializeField] private GameObject Heart3;

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
    
    void SpawnBall()
    {
        Instantiate(ballPrefab, spawnTransform.position, Quaternion.identity,transform);
    }
}
