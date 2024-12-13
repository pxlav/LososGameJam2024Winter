using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public bool isOn;
    public GameObject eqObj;
    private void Start()
    {
        eqObj.SetActive(false);
    }

    private void Update()
    {
        if(isOn == true)
        {
            eqObj.SetActive(true);
        }
        else
        {
            eqObj.SetActive(false);
        }
    }
}
