using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public bool isStartedEnding;
    public GameObject endingObj;
    public Animator endingAnimator;
    public bool isVehicle;
    public GameObject playerSprites;
    public float endingTimer;
    public GameObject endingAnimation;
    private void Start()
    {
        endingAnimator.Play("EndingStart");
        endingTimer = 7.0f;
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
            endingTimer -= Time.deltaTime;
            if(endingTimer <= 0)
            {
                endingAnimation.SetActive(true);
            }
            if (endingTimer <= -15)
            {
                SceneManager.LoadScene(0);
            }
            endingAnimator.Play("EndingEnd");
            playerSprites.SetActive(false);
        }
    }
}
