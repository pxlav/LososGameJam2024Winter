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
            colliders[0].SetActive(false);
        }
        if (windowChecked == 12)
        {
            colliders[0].SetActive(false);
        }
        if (windowChecked == 16)
        {
            colliders[0].SetActive(false);
        }
        if (windowChecked == 20)
        {
            colliders[0].SetActive(false);
        }
        if (windowChecked == 24)
        {
            colliders[0].SetActive(false);
        }
        if (windowChecked == 28)
        {
            colliders[0].SetActive(false);
        }
    }
}
