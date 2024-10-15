using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Camera cameraPlayer1;  // Caméra du joueur 1
    public Camera cameraPlayer2;  // Caméra du joueur 2
    public Rigidbody ballRigidbody;
    public GameObject ball;
    private bool isPlayer1Perspective = true; // Commence avec la caméra du joueur 1
    private bool canChangeSide = true;

    void Start()
    {
        // Commencer avec la caméra du joueur 1 et la gravité désactivée
        cameraPlayer1.enabled = true;
        cameraPlayer2.enabled = false;
        
        // Désactiver la gravité car nous sommes du côté du joueur 1
        ballRigidbody.useGravity = true;
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        if (!isPlayer1Perspective)
        {
            //ballRigidbody.velocity = new Vector3(ballRigidbody.velocity.x,
            //    ballRigidbody.velocity.y - (Physics.gravity.y), ballRigidbody.velocity.z);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Vérifiez si la balle touche le filet
        if (other.gameObject == ball && canChangeSide)
        {
            canChangeSide = false;
            StartCoroutine(WaitBeforeAllowToChangeAgain());
            if (isPlayer1Perspective)
            {
                // Activer la caméra du joueur 2 et désactiver celle du joueur 1
                cameraPlayer1.enabled = false;
                cameraPlayer2.enabled = true;

                // Activer la gravité car nous sommes du côté du joueur 2
                ballRigidbody.useGravity = true;
                isPlayer1Perspective = false;
                //ballRigidbody.velocity = Vector3.zero;
                Physics.gravity = new Vector3(0, 9.8f, 0);
            }
            else
            {
                // Activer la caméra du joueur 1 et désactiver celle du joueur 2
                cameraPlayer1.enabled = true;
                cameraPlayer2.enabled = false;

                // Désactiver la gravité car nous sommes du côté du joueur 1
                ballRigidbody.useGravity = true;
                isPlayer1Perspective = true;
                //ballRigidbody.velocity = Vector3.zero;
                Physics.gravity = new Vector3(0, -9.8f, 0);
            }
        } 
    }

    IEnumerator WaitBeforeAllowToChangeAgain()
    {
        yield return new WaitForSeconds(0.2f);
        canChangeSide = true;

    }
}




    






    

    
        
    


