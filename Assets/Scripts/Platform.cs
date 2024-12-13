using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public BoxCollider2D platformCollider;
    public bool isStaying;
    public int wichNeedToUnlock;

    private void Start()
    {
        platformCollider.gameObject.SetActive(false);
    }
    private void Update()
    {
        if(isStaying == true)
        {
            platformCollider.gameObject.SetActive(true);
        }
        else
        {
            platformCollider.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            isStaying = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isStaying = false;
        }
    }
}
