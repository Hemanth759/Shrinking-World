using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEvents : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;
    public GameObject creditsMenu;
    public Animator animator;

    void deactivateMenus() {
        mainMenu.SetActive(false);
        optionMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    void resetCurrentState() {
        animator.SetInteger("CurrentState", -1);
    }

    void activateMainMenu() {
        mainMenu.SetActive(true);
        resetCurrentState();
    }

    void activateOptionMenu() {
        optionMenu.SetActive(true);
        resetCurrentState();
    }

    void activateCreditMenu() {
        creditsMenu.SetActive(true);
        resetCurrentState();
    }
}
