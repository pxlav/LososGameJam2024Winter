using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour
{
    public bool canLose;
    public float losingTimer;
    public GameObject[] cameras;
    public GameObject losingCanvas;
    private void Start()
    {
        cameras[0].SetActive(true);
        cameras[1].SetActive(false);
        losingTimer = 10.3f;
        losingCanvas.SetActive(false);
    }
    private void Update()
    {
        if (canLose == true)
        {
            losingCanvas.SetActive(true);
            losingTimer -= Time.deltaTime;
            if (losingTimer <= 0)
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(true);
                losingCanvas.SetActive(false);
            }
        }
    }
}
