using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public variables
    public static GameManager instance;
    public GameObject createrPrefab;

    public string SceneName {
        get {
            return this.PSceneName.name;
        }
    }

    // private variables
    private Scene PSceneName;

    private void Awake() 
    {
        instance = this;
        PSceneName = SceneManager.GetActiveScene();
    }
}
