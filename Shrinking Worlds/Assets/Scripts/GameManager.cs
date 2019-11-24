using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public variables
    public static GameManager instance;
    public GameObject createrPrefab;

    // private variables

    private void Awake() 
    {
        instance = this;   
    }
}
