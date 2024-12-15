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
    public GameObject itemOptionObj;
    private void Update()
    {
        if(isWindowClicked == true)
        {
            itemOptionObj.SetActive(false);
        }
        if (isPlayer == true && isWindowClicked == false)
        {
            if (isSecond == true)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    if (apartment.optionWindowTwo == 0)
                    {
                        if (apartment.windowTwoID == 0)
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
                    }
                    else
                    {
                        playerController.isFailed = true;
                    }

                }
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    if (apartment.optionWindowTwo == 1)
                    {
                        if (apartment.windowTwoID == 0)
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
                    }
                    else
                    {
                        playerController.isFailed = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.U))
                {
                    if (apartment.optionWindowTwo == 0)
                    {
                        if (apartment.windowTwoID == 0)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                        if (apartment.windowTwoID == 1)
                        {
                            Debug.Log("DOBRZE");
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                        if (apartment.windowTwoID == 2)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                    }
                    else
                    {
                        playerController.isFailed = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.I))
                {
                    if (apartment.optionWindowTwo == 1)
                    {
                        if (apartment.windowTwoID == 0)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                        if (apartment.windowTwoID == 1)
                        {
                            Debug.Log("DOBRZE");
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                        if (apartment.windowTwoID == 2)
                        {
                            Debug.Log("ZLE");
                            playerController.isFailed = true;
                        }
                    }
                    else
                    {
                        playerController.isFailed = true;
                    }
                }


                if (Input.GetKeyDown(KeyCode.O))
                {
                    if (apartment.optionWindowTwo == 0)
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
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                    }
                    else
                    {
                        playerController.isFailed = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.P))
                {
                    if (apartment.optionWindowTwo == 1)
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
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                    }
                    else
                    {
                        playerController.isFailed = true;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    if (apartment.optionWindowOne == 0)
                    {
                        if (apartment.windowOneID == 0)
                        {
                            Debug.Log("DOBRZE");
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
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
                    else
                    {
                        playerController.isFailed = true;
                    }

                }
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    if (apartment.optionWindowOne == 1)
                    {
                        if (apartment.windowOneID == 0)
                        {
                            Debug.Log("DOBRZE");
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
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
                    else
                    {
                        playerController.isFailed = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.U))
                {
                    if (apartment.optionWindowOne == 0)
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
                    else
                    {
                        playerController.isFailed = true;
                    }
                }
                if (Input.GetKeyDown(KeyCode.I))
                {
                    if (apartment.optionWindowOne == 1)
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

                    else
                    {
                        playerController.isFailed = true;
                    }
                }

                if (Input.GetKeyDown(KeyCode.O))
                {
                    if (apartment.optionWindowOne == 0)
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
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                    }

                    else
                    {
                        playerController.isFailed = true;
                    }
                }

                if (Input.GetKeyDown(KeyCode.P))
                {
                    if (apartment.optionWindowOne == 1)
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
                            floorsBlocking.windowChecked++;
                            isWindowClicked = true;
                        }
                    }

                    else
                    {
                        playerController.isFailed = true;
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
