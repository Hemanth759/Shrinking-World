using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public varaibles
    [Range(0,15)]
    public float moveSpeed;

    [Range(50, 250)]
    public float rototionSpeed;

    // private varaibles
    private Rigidbody rb;

    // private variables
    private float rotation;
    
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // initailize the private varaibles
        rb = this.GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // gets the rotation value from input axis
        rotation = Input.GetAxisRaw("Horizontal");
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        // moves the player in its front direction
        rb.MovePosition(rb.position + this.transform.forward * -moveSpeed * Time.fixedDeltaTime);

        // rotates the car with input
        Vector3 rotationY = Vector3.up * rotation * rototionSpeed * Time.fixedDeltaTime;
        Quaternion deltaRotation = Quaternion.Euler(rotationY);
        Quaternion targetRotation = rb.rotation * deltaRotation;
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.fixedDeltaTime));    
    }
}
