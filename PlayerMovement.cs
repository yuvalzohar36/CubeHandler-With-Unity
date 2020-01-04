using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;
	public float forwardForce =2000f;
	public float slidewaysForce =500f;
    // Start is called before the first frame update
    void FixedUpdate()
    {
        rb.AddForce(Time.deltaTime* forwardForce,0, 0);

        if (Input.GetKey("a"))
        {
        	rb.AddForce(0,0,slidewaysForce*Time.deltaTime, ForceMode.VelocityChange);
        }
         if (Input.GetKey("d"))
        {
        	rb.AddForce(0,0,-slidewaysForce*Time.deltaTime, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
        	FindObjectOfType<GameManager>().EndGame();
        }
    }
  
}
