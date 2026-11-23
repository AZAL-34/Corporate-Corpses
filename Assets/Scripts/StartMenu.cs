using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject playButton;
    public GameObject exitButton;
    public bool mouseInPlayButton;
    public bool mouseInExitButton;
    
    void Start()
    {
        mouseInPlayButton = false;
        mouseInExitButton = false;
    }
}
