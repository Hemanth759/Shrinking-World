using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // puble varaibles
    public GameObject deathEffect;

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Meteror") {
            Instantiate(deathEffect, this.transform.position, this.transform.rotation);

            PlayerController movement = this.GetComponent<PlayerController>();

            Destroy(this.gameObject);
        }
    }
}
