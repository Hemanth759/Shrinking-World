using UnityEngine;

[RequireComponent(typeof(Animator))]
public class NightModeAnimation : MonoBehaviour
{
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    void stopAnimation() {
        animator.enabled = false;
    }
}
