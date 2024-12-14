using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool isOn;
    public GameObject menuObj;
    public CameraMovementFollow cameraFollow;
    public Transform[] cameraTargets;
    public CinematicCutScene cinematicScene;
    private void Start()
    {
        isOn = true;
    }

    private void Update()
    {
        if(isOn == true)
        {
            menuObj.SetActive(true);
            cameraFollow.target = cameraTargets[0];
        }
        else
        {
            menuObj.SetActive(false);
            cameraFollow.target = cameraTargets[1];
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = !isOn;
        }
    }
    public void Play()
    {
        isOn = false;
    }
    public void NewGame()
    {
        cinematicScene.canOnScene = true;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
