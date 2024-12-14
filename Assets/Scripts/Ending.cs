using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public bool isStartedEnding;
    public GameObject endingObj;
    public Animator endingAnimator;
    public bool isVehicle;
    private void Start()
    {
        endingAnimator.Play("EndingStart");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isStartedEnding = true;
        }
    }
    private void Update()
    {
        if(isStartedEnding == true)
        {
            endingObj.SetActive(true);
        }
        if(isVehicle == true)
        {
            endingAnimator.Play("EndingEnd");
        }
    }
}
