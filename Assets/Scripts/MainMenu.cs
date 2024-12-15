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
    public bool isCinematicOn;
    public float cinematicTimer;
    public GameObject playerObj;
    private void Start()
    {
        isOn = true;
        isCinematicOn = false;
        cinematicTimer = 10.0f;
        playerObj.SetActive(false);
    }

    private void Update()
    {
        if(isOn == true)
        {
            menuObj.SetActive(true);
            cameraFollow.target = cameraTargets[0];
            cameraFollow.offset.z = -10.4f;
            cameraFollow.offset.y = 0.53f;
            isCinematicOn = false;
        }
        else
        {
            menuObj.SetActive(false);
            cameraFollow.target = cameraTargets[1];
            cameraFollow.offset.z = -22.4f;
            cameraFollow.offset.y = 3.08f; ;
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = !isOn;
        }
        if(isCinematicOn == true)
        {
            cinematicTimer -= Time.deltaTime;
            playerObj.SetActive(false);
            if (cinematicTimer <= 0)
            {
                isCinematicOn = false;
                playerObj.SetActive(true);
            }
        }
    }
    public void Play()
    {
        isOn = false;
        cinematicScene.canOnScene = true;
        isCinematicOn = true;
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
