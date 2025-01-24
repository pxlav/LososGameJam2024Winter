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
    public GameLose lose;
    public SantaClausMoving playerController;
    public Ending ending;
    public TextMeshPro tmp;
    public GameObject[] orders;
    private void Update()

    {
        if(playTime < 60)
        {
            orders[0].SetActive(true);
            orders[1].SetActive(false);
            orders[2].SetActive(false);
        }
        if (playTime > 60 && playTime < 120)
        {
            orders[0].SetActive(false);
            orders[1].SetActive(true);
            orders[2].SetActive(false);
        }
        if (playTime > 120)
        {
            orders[0].SetActive(false);
            orders[1].SetActive(false);
            orders[2].SetActive(true);
        }
        tmp.text = playTime.ToString("0.0");
        if (menu.isOn == false && menu.isCinematicOn == false && playerController.isFailed == false && ending.isVehicle == false)
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
