using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaClausMoving : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float moveSpeed;
    public float jumpSpeed;
    public GroundDetector detector;
    public int jumpCounter;
    public Equipment equipment;
    private void Update()
    {
        float move = Input.GetAxis("Horizontal");
        playerRB.velocity = new Vector2(move * moveSpeed, playerRB.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCounter > 0 && detector.isGround)
                playerRB.AddForce(Vector2.up * jumpSpeed * 10);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Window")
        {
            equipment.isOn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Window")
        {
            equipment.isOn = false;
        }
    }
}
