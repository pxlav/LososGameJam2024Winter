using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CinematicCutScene : MonoBehaviour
{
    public bool canOnScene;
    public float sceneTimer;
    public GameObject sceneObj;
    public MainMenu menu;
    private void Start()
    {
        sceneTimer = 10.0f;
    }

    private void Update()
    {
        if(canOnScene == true)
        {
            sceneObj.SetActive(true);
        }
        else
        {
            sceneObj.SetActive(false);
        }
        if(canOnScene == true)
        {
            menu.isOn = false;
            sceneTimer -= Time.deltaTime;
            if(sceneTimer <= 0)
            {
                canOnScene = false;
            }
        }
    }
}
