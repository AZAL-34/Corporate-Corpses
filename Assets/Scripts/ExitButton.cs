using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public StartMenu menuScript;

    private void OnMouseEnter()
    {
        menuScript.mouseInExitButton = true;
    }

    private void OnMouseExit()
    {
        menuScript.mouseInExitButton = false;
    }

    private void OnMouseDown()
    {
        if (menuScript.mouseInExitButton)
        {
            GetComponent<AudioSource>().Play();
            Application.Quit();
        }
    }
}
