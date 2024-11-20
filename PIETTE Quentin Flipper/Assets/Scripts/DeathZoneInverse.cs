using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneInverse : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    { 
        Physics.gravity = new Vector3(0, -9.81f, 0);
        Destroy(other.gameObject);
      
        GameManager.instance.LoseBallInverse();
        BallControl.instance.LookPlayer1();
        BallControl.instance.heartPlayer1.SetActive(true);
        BallControl.instance.heartPlayer2.SetActive(false);
        ScoreManager.instance.score2 -= 50;
        ScoreManager.instance.TextRefresh();
    }
}
