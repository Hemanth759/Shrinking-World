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
                animator.SetTrigger("ChangingState");
                Invoke("StartGame", 0.6f);
                break;
            case "Options Button":
                animator.SetTrigger("ChangingState");
                Invoke("ShowOptions", 0.6f);
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

    void StartGame() {
        SceneManager.LoadScene(2);
    }

    void ShowMainMenu() {
        animator.SetInteger("CurrentState", 0);
    }

    void ShowOptions() {
        animator.SetInteger("CurrentState", 1);
    }

    void ShowCredits() {
        animator.SetInteger("CurrentState", 2);
    }
}
