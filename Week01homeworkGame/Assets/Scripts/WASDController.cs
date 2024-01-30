using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{
    public float maxVelocity = 10; //declaring the maximum we want the player's speed to reach
    public float forceAmount = 100; //declaring the amount of force to be applied to propel the player in a Vector3 direction
   
    Rigidbody rb; //variable for the player's rigid body, for physics based movement
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //on start, we declare that rb is the object this script is attached to's rigid body
    }

    // We use fixed update for smoother physics movement
    private void FixedUpdate()
    {
        //pushing rigid body forward, back, left and right in Vector3 (x,y,z) position by multiplying the position direction with the declared force amount
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(forceAmount * Vector3.forward + forceAmount * Vector3.up); //moving forward on z axis, and up on y axis
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(forceAmount * Vector3.back + forceAmount * Vector3.down); //moving backwards on z axis, and down on y axis
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(forceAmount * Vector3.left);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceAmount * Vector3.right);
        }

        //use normalization and magnitude to maintain the player's velocity to be at max velocity or less. Normalized means a consistent rate of 1 unit, limiting diagonal momentum  
        if (rb.velocity.magnitude >= maxVelocity)
        {
            Vector3 newVelocity = rb.velocity.normalized; //updating the player's velocity to be normalized
            newVelocity *= maxVelocity; //the player's new & updating velocity is capped at the max velocity
            rb.velocity = newVelocity; //confirming the player's velocity is updated to be the "new velocity" 
        }
    }
}
