using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLightFollow : MonoBehaviour
{
    // public variables
    public GameObject target;

    // private variables
    private Light directionLight;
    private Quaternion targetRotation;

    private void Start()
    {
        directionLight = this.GetComponentInChildren<Light>();
    }

    private void FixedUpdate() 
    {
        this.transform.LookAt(target.transform);
    }
}
