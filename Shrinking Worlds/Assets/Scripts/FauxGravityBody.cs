using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour
{
    // public varailables
    private FauxGravityAttractor fauxGravityAttractor;
    public bool placeOnSurface;

    // private varaibles
    private Transform myTransform;
    private Rigidbody rb;

    
    /// <summary>
    // Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // get the only instance of attractor
        fauxGravityAttractor = FauxGravityAttractor.instance;

        // setup the rigidbody consraints
        rb = this.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        rb.useGravity = false;        

        // asign transform of this object to varaible
        myTransform = this.transform;

        // place the player on surface
        if(placeOnSurface) {
            fauxGravityAttractor.PlaceOnSurface(rb);
        }
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        fauxGravityAttractor.Attract(myTransform);        
    }
}
