using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
   public float strength = 1;
   public Animation anim;
   
   [SerializeField] public GameObject particlePrefab1;

   [SerializeField] public int points;
   private void OnCollisionEnter(Collision collision)
   {
      Vector3 force = (collision.transform.position - transform.position).normalized * strength;
      
      collision.rigidbody.AddForce(force);
      
      GameObject particleInstance = Instantiate(particlePrefab1, collision.contacts[0].point, Quaternion.identity, null);
      
      particleInstance.transform.LookAt(collision.contacts[0].point - collision.contacts[0].normal);
      Destroy(particleInstance,3);
      anim.Play("Bumper Bump");
      
      ScoreManager.instance.AddPoints(points);
   }
}
