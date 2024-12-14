using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLose : MonoBehaviour
{
    public bool canLose;
    public float losingTimer;
    public GameObject losingCanvas;
    private void Start()
    {
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
                losingCanvas.SetActive(false);
            }
        }
    }
}
