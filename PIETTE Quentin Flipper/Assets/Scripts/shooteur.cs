using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooteur : MonoBehaviour
{
    public SpringJoint springJoint;

    public KeyCode key = KeyCode.Space;

    public float defaultValue;

    public float minValue;

    public float currentValue;
    public float incrementSpeed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        defaultValue = springJoint.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(key))
        {
            currentValue -= incrementSpeed;
        }
        else
        {
            currentValue = defaultValue;
        }

        if (currentValue < minValue)
        {
            currentValue = minValue;
        }

        springJoint.spring = currentValue;


    }
}
