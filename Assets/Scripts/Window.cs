using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public bool isPlayer;
    public bool isSecond;
    public Apartment apartment;
    public FloorsBlocking floorsBlocking;
    public bool isWindowClicked;
    public SantaClausMoving playerController;
    private void Update()
    {
        if(isPlayer == true && isWindowClicked == false)
        {
            if(isSecond == true)
            {
                if(Input.GetKeyDown(KeyCode.T))
                {
                    if(apartment.windowTwoID == 0)
                    {
                        Debug.Log("DOBRZE");
                        floorsBlocking.windowChecked++;
                        isWindowClicked = true;
                    }
                    if (apartment.windowTwoID == 1)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                    if (apartment.windowTwoID == 2)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                    if (apartment.windowTwoID == 2)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                    if (apartment.windowTwoID == 2)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }

                }
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    if (apartment.windowTwoID == 0)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                    if (apartment.windowTwoID == 1)
                    {
                        isWindowClicked = true;
                        floorsBlocking.windowChecked++;
                        Debug.Log("DOBRZE");
                    }
                    if (apartment.windowTwoID == 2)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.U))
                {
                    if (apartment.windowTwoID == 0)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                    if (apartment.windowTwoID == 1)
                    {
                        Debug.Log("ZLE");
                        playerController.isFailed = true;
                    }
                    if (apartment.windowTwoID == 2)
                    {
                        Debug.Log("DOBRZE");
                        isWindowClicked = true;
                        floorsBlocking.windowChecked++;
                    }
                }
            }
            else
            {
                if(isWindowClicked == false)
                {
                    if (Input.GetKeyDown(KeyCode.T))
                    {
                        if (apartment.windowOneID == 0)
                        {
                            Debug.Log("DOBRZE");
                            isWindowClicked = true;
                            floorsBlocking.windowChecked++;
                        }
                        if (apartment.windowOneID == 1)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                        if (apartment.windowOneID == 2)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.Y))
                    {
                        if (apartment.windowOneID == 0)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                        if (apartment.windowOneID == 1)
                        {
                            Debug.Log("DOBRZE");
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                        if (apartment.windowOneID == 2)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                    }
                    if (Input.GetKeyDown(KeyCode.U))
                    {
                        if (apartment.windowOneID == 0)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                        if (apartment.windowOneID == 1)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                        if (apartment.windowOneID == 2)
                        {
                            Debug.Log("DOBRZE"); 
                            isWindowClicked = true;
                            floorsBlocking.windowChecked++;
                        }
                    }
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isPlayer = false;
        }
    }
}
