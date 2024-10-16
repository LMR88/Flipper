using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int ballCount;

    [SerializeField] private int lifeCount = 3;

    public static GameManager instance;

    [SerializeField] public GameObject ballPrefab;

    [SerializeField] private Transform spawnTransform;

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
            Debug.Log("Game Over");
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
