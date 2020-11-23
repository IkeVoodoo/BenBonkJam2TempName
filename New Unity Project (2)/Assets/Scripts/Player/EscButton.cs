using UnityEngine;

public class EscButton : MonoBehaviour
{

    [SerializeField]
    private Canvas canvas = default;

    bool EscapeMenuToggle = true;

    void UnPause()
    {
        //Hide cursor
        Cursor.visible = false;
        //Start time
        Time.timeScale = 1;
        //Set EscapeMenuToggle to true
        EscapeMenuToggle = true;
        //Hide Menu
        canvas.gameObject.SetActive(false);

    }
    void Pause()
    {
        //Show cursor
        Cursor.visible = true;
        //Stop time
        Time.timeScale = 0;
        //Set EscapeMenuToggle to false
        EscapeMenuToggle = false;
        //Show Menu
        canvas.gameObject.SetActive(true);
    }

    void Update()
    {
        //If Escape is pressed and EscapeMenuToggle is false run UnPause function
        if (Input.GetKeyDown(KeyCode.Escape)&& EscapeMenuToggle == false)
        {
            //Pause Game
            UnPause();

            //If Escape is pressed and EscapeMenuToggle is true run Pause function
        } else if (Input.GetKeyDown(KeyCode.Escape) && EscapeMenuToggle == true)
        {
            //Unpause Game
            Pause();
        }

        //If EscapeMenuToggle is false unlock cursor
        if(!EscapeMenuToggle)
            Cursor.lockState = CursorLockMode.None;
        else
            //If EscapeMenuToggle is true lock cursor
            Cursor.lockState = CursorLockMode.Locked;
    }
}
