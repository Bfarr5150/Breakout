using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    [SerializeField]
    private PlayerData playerData;
    private GameObject gameManagerObj;
    private GameObject playerDataObj;
    private bool ballOffScreen = false;
    public float speed = 1.5f;
    Vector3 moveVector = new Vector3(0, 1, 0);

    // Brick variables
    public GameObject[] greenBricks;
    public GameObject[] blueBricks;
    public GameObject[] purpleBricks;
    public GameObject[] redBricks;


    void Start()
    {
        // Find GameObject with GameManager tag
        gameManagerObj = GameObject.FindWithTag("GameManager").gameObject;
        gameManager = gameManagerObj.GetComponent<GameManager>();

        // Find GameObject with PlayerData tag
        playerDataObj = GameObject.FindWithTag("PlayerData").gameObject;
        playerData = playerDataObj.GetComponent<PlayerData>();

        // Create array of all bricks tagged "Green"
        greenBricks = GameObject.FindGameObjectsWithTag("Green");

        // Create array of all bricks tagged "Blue"
        blueBricks = GameObject.FindGameObjectsWithTag("Blue");

        // Create array of all bricks tagged "Purple"
        blueBricks = GameObject.FindGameObjectsWithTag("Purple");

    }




    // Update is called once per frame
    void Update()
    {
        // Move direction
        Move(moveVector);

        // Check to see if ball is out of bounds
        if (this.transform.position.y < -7)
        {
            ballOffScreen = true;
            BallDeathCheck();
        }
    }


    // Ball death check - Respawn ball if true
    void BallDeathCheck()
    {
        if (playerData.life > 0)
        {
            if (ballOffScreen == true)
            {
                this.transform.position = gameManager.resetBallPos;
                gameManager.ResetBall();
                speed = 3f;
                playerData.life--;
            }
        }
    }


    /* 
     // Disable ball if life == 0
     // Didn't end up working
     
    void DisableBallObj()
    {
        if (playerData.life < 1)
        {
            gameManager.DisableBall();
        }
    }
    */
    


    // Move ball in set direction
    public void Move(Vector3 moveDirection)
    {
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }


    // Detect collision with collider
    public void OnCollisionEnter(Collision collision)
    {
        // Check if collision was with a greenBrick
        foreach (GameObject greenBricks in greenBricks)
        {
            if (collision.gameObject == greenBricks)
            {
                BrickGreen brickGreen = greenBricks.GetComponent<BrickGreen>();
                float greenBrickSpeed = brickGreen.speed;
                speed = greenBrickSpeed;
                moveVector = new Vector3(moveVector.x, -moveVector.y, 0);
                greenBricks.SetActive(false);
                break;
            }
        }

        // Check if collision was with a blueBrick
        foreach (GameObject blueBricks in blueBricks)
        {
            if (collision.gameObject == blueBricks)
            {
                BrickBlue brickBlue = blueBricks.GetComponent<BrickBlue>();
                float blueBrickSpeed = brickBlue.speed;
                speed = blueBrickSpeed;
                moveVector = new Vector3(moveVector.x, -moveVector.y, 0);
                blueBricks.SetActive(false);
                break;
            }
        }

        // Check if collision was with a purpleBrick
        foreach (GameObject purpleBricks in purpleBricks)
        {
            if (collision.gameObject == purpleBricks)
            {
                BrickPurple brickPurple = purpleBricks.GetComponent<BrickPurple>();
                float purpleBrickSpeed = brickPurple.speed;
                speed = purpleBrickSpeed;
                moveVector = new Vector3(moveVector.x, -moveVector.y, 0);
                purpleBricks.SetActive(false);
                break;
            }
        }

        // Check collision with Left/Right bounds
        if (collision.gameObject.CompareTag("LeftBound"))
        {
            moveVector = new Vector3(-moveVector.x, moveVector.y, 0);
        }
        if (collision.gameObject.CompareTag("RightBound"))
        {
            moveVector = new Vector3(-moveVector.x, moveVector.y, 0);
        }

        // Check collision with Paddle
        if (collision.gameObject.CompareTag("Paddle"))
        {
            moveVector = new Vector3(moveVector.x, -moveVector.y, 0);
        }

        // Get which collider was hit
        Debug.Log("Ball Collided with: " + collision.collider.name);
    }





}
