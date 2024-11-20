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
        int rand = Random.Range(0, 2);
        if (rand ==0)
        {
            rand = -1;
        }
        GetComponent<Rigidbody>().AddForce(new Vector3(0,rand,0),ForceMode.Impulse);
    }
    
}
    
