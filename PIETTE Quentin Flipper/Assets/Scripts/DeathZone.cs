using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { 
        Physics.gravity = new Vector3(0, -9.81f, 0);
      Destroy(other.gameObject);
      
      GameManager.instance.LoseBall();
      BallControl.instance.LookPlayer1();
      
      ScoreManager.instance.AddPoints(-50);
    }
}