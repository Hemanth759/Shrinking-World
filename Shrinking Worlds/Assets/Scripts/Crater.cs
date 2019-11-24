using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crater : FauxGravityBody
{
    public float shrinkSpeed = 0.05f;
    public ParticleSystem expolsionEffects;

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
            expolsionEffects.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            Destroy(this.gameObject, 3f);
        }
    }
}
