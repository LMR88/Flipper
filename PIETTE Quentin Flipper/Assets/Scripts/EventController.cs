using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.Events;

public class EventController : MonoBehaviour
{
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    [SerializeField] UnityEvent onCollisionEnter;

    private void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }

    private void OnCollisionEnter(Collision collision)
    {
        onCollisionEnter.Invoke();
    }
}
