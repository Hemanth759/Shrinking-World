using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GameOverButtons : MonoBehaviour
{
    // private variables
    private AudioSource audioSource;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    public void onClick() {
        switch (this.gameObject.name)
        {
            case "RetryButton":
                audioSource.Play();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case "QuitButton":
                audioSource.Play();
                Application.Quit();
                break;
            default:
                return;
        }
    }
}
