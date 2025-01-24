using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaClausMoving : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float moveSpeed;
    public float jumpSpeed;
    public GroundDetector detector;
    public int jumpCounter;
    public Equipment equipment;
    public Animator playerAnimator;
    public bool isFailed;
    public GameObject playerAnimated;
    public GameObject playerLose;
    public float deadTimer;
    public GameObject playerLoseCanvas;
    public bool isLadder;
    public MainMenu menu;
    public bool isRight;
    public GameObject wrongGift;
    private void Start()
    {
        playerAnimated.SetActive(true);
        playerLose.SetActive(false);
        deadTimer = 3.0f;
        wrongGift.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            isRight = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            isRight = false;
        }
        if (isFailed == false)
        {
            if (menu.isOn == false && menu.cinematicScene.canOnScene == false)
            {
                float move = Input.GetAxis("Horizontal");
                playerRB.velocity = new Vector2(move * moveSpeed, playerRB.velocity.y);
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (jumpCounter > 0 && detector.isGround)
                        playerRB.AddForce(Vector2.up * jumpSpeed * 10);
                }
                if (isLadder == false && !Input.GetKey(KeyCode.W))
                {

                    if (detector.isGround == false)
                    {
                        if (isRight == true)
                        {
                            playerAnimator.Play("JumpRight");
                        }
                        else
                        {
                            playerAnimator.Play("JumpLeft");
                        }
                    }
                    else
                    {
                        if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("JumpRight"))
                        {
                            playerAnimator.Play("IdleRight");
                        }
                        if (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("JumpLeft"))
                        {
                            playerAnimator.Play("IdleLeft");
                        }
                    }
                }
                if (isLadder == false && !Input.GetKey(KeyCode.W) && detector.isGround == true)
                {

                    if (Input.GetKeyUp(KeyCode.A))
                    {
                        playerAnimator.Play("IdleLeft");
                    }
                    if (Input.GetKeyUp(KeyCode.D))
                    {
                        playerAnimator.Play("IdleRight");
                    }
                    if (Input.GetKey(KeyCode.A))
                    {
                        playerAnimator.Play("WalkLeft");
                    }
                    if (Input.GetKey(KeyCode.D))
                    {
                        playerAnimator.Play("WalkRight");
                    }
                }
            }
        }
        else
        {
            playerAnimated.SetActive(false);
            playerLose.SetActive(true);
            wrongGift.SetActive(true);
            deadTimer -= Time.deltaTime;
            if (deadTimer <= 0)
            {
                playerLoseCanvas.SetActive(true);
            }
            if (deadTimer <= -8)
            {
                SceneManager.LoadScene(0);
            }
        }
        if (isLadder == true && Input.GetKey(KeyCode.W))
        {
            playerAnimator.Play("Ladder");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Window")
        {
            equipment.isOn = true;
        }
        if (collision.tag == "Ladder")
        {
            isLadder = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Window")
        {
            equipment.isOn = false;
        }
        if (collision.tag == "Ladder")
        {
            isLadder = false;
        }
    }
}
