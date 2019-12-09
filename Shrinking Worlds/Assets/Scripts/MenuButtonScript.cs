using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    // public varaibles
    public AudioSource audioSource;

    // private varaibles
    private Animator animator;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        audioSource = this.GetComponentInParent<AudioSource>();
        animator = GameObject.Find("GameEnv").GetComponent<Animator>();
    }

    // button functions
    public void onClick() {
        audioSource.Play();

        switch (this.gameObject.name)
        {
            case "Start Game Button":
                SceneManager.LoadScene(2);
                break;
            case "Options Button":
                animator.SetBool("ChangingState", true);
                break;
            case "Credits Button":
                break;
            case "Quit Button":
                Application.Quit();
                break;
            default:
                break;
        }
    }

    public void onHover() {
        Debug.Log("enetering event");
    }

    public void onExitHover() {
        Debug.Log("exiting hover");
    }
}
