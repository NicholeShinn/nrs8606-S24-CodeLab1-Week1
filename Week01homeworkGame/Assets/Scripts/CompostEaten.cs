using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompostEaten : MonoBehaviour
{
    public AudioSource wormChomp;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CompostCollection.scoreValue += 666;   //once the player worm, collides with the compost, the value goes up
            wormChomp.Play(); //play chomping sound
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player") {

            CompostCollection.scoreValue += 666;   //once the player worm, collides with the compost, and stays in it's area the value goes up
            
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") {

            Destroy(this.gameObject);   //once the player leaves, destroy game object
        }
    }
}
