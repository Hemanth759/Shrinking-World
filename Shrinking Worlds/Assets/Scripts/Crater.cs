using UnityEngine;

public class Crater : FauxGravityBody
{
    // public variables
    public float shrinkSpeed = 0.05f;

    // private variables
    public ParticleSystem expolsionEffects;

    bool isVanishing = false;

    // Update is called once per frame
    void Update()
    {
        if(isVanishing) {
            return;
        }    

        this.transform.localScale *= 1f - shrinkSpeed * Time.deltaTime;

        if(this.transform.localScale.x <= .25f) {
            isVanishing = true;
            
            expolsionEffects.Stop(true, ParticleSystemStopBehavior.StopEmitting);
            
            Destroy(this.gameObject);
        }
    }
}
