using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float playTime;
    public bool canPlusTimer;
    public TextMeshProUGUI tmProTimer;
    public GameObject timerObj;
    public MainMenu menu;
    private void Update()
    {
        if(menu.isOn == false && menu.isCinematicOn == false)
        {
            timerObj.SetActive(true);
            playTime += Time.deltaTime;
        }
        if (menu.isOn == true || menu.isCinematicOn)
        {
            timerObj.SetActive(false);
        }
        tmProTimer.text = playTime.ToString("0.0");
    }
}
