using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        GameManager.instance.ballCount = GameManager.instance.ballCount + 1;
    }
}
    
