using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody ballPrefabRigidbody;
    public GameObject ballPrefab;
    private bool isPlayer1Perspective = true; // Commence avec la caméra du joueur 1
    private bool canChangeSide = true;
    public TMP_Text Joueur;
    public static BallControl instance;
    public bool player1Targeted = true;
    public float rotationSpeed;
    public Transform transformParent;
    public bool points;

    void Start()
    {
        Joueur.text = "Joueur 1";
        
        ballPrefabRigidbody.useGravity = true;
    }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (player1Targeted)
        {
            transformParent.rotation = Quaternion.Euler(0,0,Mathf.Lerp(transformParent.eulerAngles.z,0,rotationSpeed));
        }
        else
        {
            transformParent.rotation = Quaternion.Euler(0,0,Mathf.Lerp(transformParent.eulerAngles.z,180,rotationSpeed));
        }
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
        if (other.gameObject.CompareTag("Ball") && canChangeSide)
        {
            canChangeSide = false;
            StartCoroutine(WaitBeforeAllowToChangeAgain());
            if (isPlayer1Perspective)
            {
                LookPlayer2();
            }
            else
            {
                LookPlayer1();
            }
        } 
    }

    public void LookPlayer1()
    {
        // Activer la caméra du joueur 1 et désactiver celle du joueur 2
        player1Targeted = true;

        ScoreManager.instance.player1Targeted = true;
       
        Joueur.text = "Joueur 1";

        // Désactiver la gravité car nous sommes du côté du joueur 1
        ballPrefabRigidbody.useGravity = true;
        isPlayer1Perspective = true;
        //ballRigidbody.velocity = Vector3.zero;
        Physics.gravity = new Vector3(0, -9.8f, 0);
    }

    public void LookPlayer2()
    {
        player1Targeted = false;

        ScoreManager.instance.player1Targeted = false;
        
        Joueur.text = "Joueur 2";

        // Activer la gravité car nous sommes du côté du joueur 2
        ballPrefabRigidbody.useGravity = true;
        isPlayer1Perspective = false;
        //ballRigidbody.velocity = Vector3.zero;
        Physics.gravity = new Vector3(0, 9.8f, 0);
    }

    IEnumerator WaitBeforeAllowToChangeAgain()
    {
        yield return new WaitForSeconds(0.2f);
        canChangeSide = true;

    }
}




    






    

    
        
    


