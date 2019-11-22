using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteror : MonoBehaviour
{
    // public variables
    public GameObject crater;
	public SphereCollider sphereCol;
	public ParticleSystem trail;
    public Transform craterParent;

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        Quaternion rot = Quaternion.LookRotation(this.transform.position.normalized);
        rot *= Quaternion.Euler(90f, 0f, 0f);
        GameObject craterChild = Instantiate(crater, other.contacts[0].point, rot);
        craterChild.transform.parent = craterParent;

        sphereCol.enabled = false;
		trail.Stop(true, ParticleSystemStopBehavior.StopEmitting);

        Destroy(this.gameObject, 4f);
    }
}
