using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public void onClick() {
        switch (this.gameObject.name)
        {
            case "RetryButton":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case "QuitButton":
                Application.Quit();
                break;
            default:
                return;
        }
    }
}
