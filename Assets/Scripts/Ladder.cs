using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public GameObject playerObj;
    [SerializeField] bool isTouchingPlayer;
    public Rigidbody2D playerRig;
    public float climbingSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isTouchingPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isTouchingPlayer = false;

        }
    }
    private void Update()
    {
        if (isTouchingPlayer == true)
        {
            Climbing(climbingSpeed);
        }
    }
    void Climbing(float speed)
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerRig.velocity = new Vector2(0, speed);
        }
    }
}
