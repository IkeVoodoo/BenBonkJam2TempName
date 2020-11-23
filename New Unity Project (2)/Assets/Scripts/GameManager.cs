using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Main Menu
    private bool fullscreen = true;
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit() {
        Application.Quit();
    }
        public void Fullscreen()
    {
        if (fullscreen)
        {
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
}
