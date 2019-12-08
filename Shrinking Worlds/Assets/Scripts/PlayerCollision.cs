using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerCollision : MonoBehaviour
{
    // public variables
    public GameObject deathEffect;
    
    // private variables
    private AudioSource audioSource;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        audioSource = this.GetComponent<AudioSource> ();
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Meteror") {
            audioSource.Stop();

            // creates the deathEffect instance of the car
            Instantiate(deathEffect, this.transform.position, this.transform.rotation);

            PlayerController movement = this.GetComponent<PlayerController>();

            Destroy(this.gameObject);
        }
    }
}
