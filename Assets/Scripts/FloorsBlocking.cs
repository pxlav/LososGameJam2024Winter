using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorsBlocking : MonoBehaviour
{
    public int windowChecked;
    public GameObject[] colliders;
    private void Update()
    {
        if(windowChecked == 4)
        {
            colliders[0].SetActive(false);
        }
        if (windowChecked == 8)
        {
            colliders[1].SetActive(false);
        }
        if (windowChecked == 12)
        {
            colliders[2].SetActive(false);
        }
        if (windowChecked == 16)
        {
            colliders[3].SetActive(false);
        }
        if (windowChecked == 20)
        {
            colliders[4].SetActive(false);
        }
        if (windowChecked == 24)
        {
            colliders[5].SetActive(false);
        }
        if (windowChecked == 28)
        {
            colliders[6].SetActive(false);
        }
        if (windowChecked == 32)
        {
            colliders[7].SetActive(false);
        }
        if (windowChecked == 36)
        {
            colliders[8].SetActive(false);
        }
        if (windowChecked == 40)
        {
            colliders[9].SetActive(false);
        }
        if (windowChecked == 44)
        {
            colliders[10].SetActive(false);
        }
        if (windowChecked == 48)
        {
            colliders[11].SetActive(false);
        }
        if (windowChecked == 52)
        {
            colliders[12].SetActive(false);
        }
        if (windowChecked == 56)
        {
            colliders[13].SetActive(false);
        }
        if (windowChecked == 60)
        {
            colliders[14].SetActive(false);
        }
        if (windowChecked == 64)
        {
            colliders[15].SetActive(false);
        }
        if (windowChecked == 68)
        {
            colliders[16].SetActive(false);
        }
    }
}
