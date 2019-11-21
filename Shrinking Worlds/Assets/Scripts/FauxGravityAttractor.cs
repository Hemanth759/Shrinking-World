using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{
    public static FauxGravityAttractor instance;
    private SphereCollider col;

    private void Awake() {
        instance = this;
        col = instance.GetComponent<SphereCollider>();
    }

    // public varaible
    public float gravity = -10f;

    public void PlaceOnSurface(Rigidbody bodyRB) {
        bodyRB.MovePosition((bodyRB.position - this.transform.position).normalized * (transform.localScale.x * col.radius));
    }

    public void Attract(Rigidbody body) 
    {
        Vector3 gravityUp = (body.position - this.transform.position).normalized;

        body.AddForce(gravityUp * gravity);

        Quaternion targetRotation = Quaternion.FromToRotation(body.transform.up, gravityUp) * body.rotation;
        body.MoveRotation(targetRotation);
    }
}
