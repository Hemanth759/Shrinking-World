using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crater : FauxGravityBody
{
    public float shrinkSpeed = 0.05f;

    bool isVanishing = false;

    // Update is called once per frame
    void Update()
    {
        if(isVanishing) {
            return;
        }    

        this.transform.localScale *= 1f - shrinkSpeed * Time.deltaTime;

        if(this.transform.localScale.x <= .5f) {
            isVanishing = true;
            Destroy(this.gameObject, 3f);
        }
    }
}
