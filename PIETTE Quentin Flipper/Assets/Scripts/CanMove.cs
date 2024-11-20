using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanMove : MonoBehaviour
{
    float moveHorizontal=0;
    float moveVertical=0;
    public float moveSpeed = 0.5f;
    public float xMinLim=-2f;
    public float xMaxLim=2f;
    public float yMinLim=-2f;
    public float yMaxLim=2f;
   

    public bool canMove;
    
    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
       

            Vector3 direction = new Vector3(moveHorizontal,moveVertical,0);
            direction = direction.normalized;
            GetComponent<Rigidbody>().velocity= direction * moveSpeed;

            Vector3 initialPosition = transform.position;
            float newX = Mathf.Clamp(initialPosition.x, xMinLim, xMaxLim);
            float newY = Mathf.Clamp(initialPosition.y, yMinLim, yMaxLim);
            transform.position = new Vector3(newX, newY, 0);
        }
       
    }
}
