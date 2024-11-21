using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    void Start()
    {
        GameManager.instance.ballCount = GameManager.instance.ballCount + 1;

        randomInitialVelocity();
    }

    public void randomInitialVelocity()
    {
        int rand = Random.Range(0, 2);
        if (rand ==0)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(rand,0,0),ForceMode.Impulse);
        }
        else
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(rand,1,0),ForceMode.Impulse);
        }
    }
    
}
    
