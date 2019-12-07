using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkPlanet : MonoBehaviour
{
    // public variables

    [Range(.0f, .05f)]
    public float shrinkSpeed;

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        this.transform.localScale *= 1f - (shrinkSpeed * Time.fixedDeltaTime);
    }
}
