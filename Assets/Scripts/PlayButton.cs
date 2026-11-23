using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public StartMenu menuScript;

    private void OnMouseEnter()
    {
        menuScript.mouseInPlayButton = true;
    }

    private void OnMouseExit()
    {
        menuScript.mouseInPlayButton = false;
    }

    private void OnMouseDown()
    {
        if (menuScript.mouseInPlayButton)
        {
            GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("Floor1");
        }
    }
}
