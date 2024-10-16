using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBumper : MonoBehaviour
{
   public float strength = 1;
   public Animation anim;

   [SerializeField] public GameObject particlePrefab;
   
   [SerializeField] public int points;


   private void OnCollisionEnter(Collision collision)
   {
      Vector3 force = -collision.contacts[0].normal * strength;
      collision.rigidbody.AddForce(force);

      GameObject particleInstance = Instantiate(particlePrefab, collision.contacts[0].point, Quaternion.identity, null);
      
      particleInstance.transform.LookAt(collision.contacts[0].point - collision.contacts[0].normal);
      Destroy(particleInstance,3);
      anim.Play();
      
      ScoreManager.instance.AddPoints(points);
   }
}
