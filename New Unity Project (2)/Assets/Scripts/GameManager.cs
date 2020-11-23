using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Main Menu
    private GameObject mainMenu;
    private GameObject optionsMenu;
    private GameObject creditsMenu;
    private bool isOptionsMenuOpened = false;
    private bool isCreditsMenuOpened = false;
    private bool fullscreen = true;
    private void Start() {
        mainMenu = GameObject.Find("Canvas/Main");
        optionsMenu = GameObject.Find("Canvas/Options");
        creditsMenu = GameObject.Find("Canvas/Credits");
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }
    public void Update() {
        if (isOptionsMenuOpened && Input.GetKeyDown(KeyCode.Escape)) {
            mainMenu.SetActive(true);
            optionsMenu.SetActive(false);
            isOptionsMenuOpened = false;
        }
        if (isCreditsMenuOpened && Input.GetKeyDown(KeyCode.Escape)) {
            mainMenu.SetActive(true);
            creditsMenu.SetActive(false);
            isCreditsMenuOpened = false;
        }
    }
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit() {
        Application.Quit();
    }
    public void Fullscreen()
    {
        if (fullscreen) {
            fullscreen = false;
            Screen.fullScreen = false;
            Debug.Log("Fullscreen OFF");
        } else if (!fullscreen)
        {
            fullscreen = true;
            Screen.fullScreen = true;
            Debug.Log("Fullscreen ON");
        }
    }
    public void isOptionsMenuOpen() {
        if (isOptionsMenuOpened) {
            isOptionsMenuOpened = false;
        } else if (!isOptionsMenuOpened) {
            isOptionsMenuOpened = true;
        }
    }
    public void isCreditsMenuOpen() {
        if (isCreditsMenuOpened) {
            isCreditsMenuOpened = false;
        } else if (!isCreditsMenuOpened) {
            isCreditsMenuOpened = true;
        }
    }
}
