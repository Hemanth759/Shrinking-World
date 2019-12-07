using UnityEngine;

public class Meteror : MonoBehaviour
{
    // public variables
	public SphereCollider sphereCol;
	public ParticleSystem trail;

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter(Collision other)
    {
        Quaternion rot = Quaternion.LookRotation(this.transform.position.normalized);
        rot *= Quaternion.Euler(90f, 0f, 0f);
        Debug.Log(other.contacts[0].point);
        GameObject craterChild = Instantiate(GameManager.instance.createrPrefab, other.contacts[0].point, rot);

        sphereCol.enabled = false;
		trail.Stop(true, ParticleSystemStopBehavior.StopEmitting);

        Destroy(this.gameObject, 4f);
    }
}
