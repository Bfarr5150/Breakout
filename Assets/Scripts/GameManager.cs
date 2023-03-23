using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Script dependencies
    public PlayerData playerData;
    //private Ball ball;

    // Spawn variables
    public GameObject greenBrick;
    public GameObject blueBrick;
    public GameObject purpleBrick;
    public GameObject redBrick;
    public GameObject ballObj;
    public GameObject paddle;
    public GameObject topBound;

    // Respawned ball position
    public Vector3 resetBallPos;

    // Game Over variables
    public TextMeshProUGUI gameOverScore;
    public GameObject gameOverOverlay;

    void Start()
    {
        SpawnBricks();
        SpawnBall();
        SpawnPaddle();
        SpawnTopBound();
        Debug.Log("Lives = " + playerData.life);

    }

    void Update()
    {
        GameOver();
    }


    // Spawn Bricks
    void SpawnBricks()
    {
        int brickCount = 13;
        Vector3 greenSpawnPos = greenBrick.transform.position;
        Vector3 blueSpawnPos = blueBrick.transform.position;
        Vector3 purpleSpawnPos = purpleBrick.transform.position;
        Vector3 redSpawnPos = redBrick.transform.position;

        for (int i = 0; i < brickCount; i++)
        {
            // Instantiate brick objects
            GameObject spawnedBrickR1 = Instantiate(greenBrick, greenSpawnPos + new Vector3(i * 2, greenSpawnPos.y - 0.75f, 0), Quaternion.identity);
            GameObject spawnedBrickR2 = Instantiate(greenBrick, greenSpawnPos + new Vector3(i * 2, greenSpawnPos.y, 0), Quaternion.identity);
            GameObject spawnedBrickR3 = Instantiate(blueBrick, greenSpawnPos + new Vector3(i * 2, blueSpawnPos.y - 0.75f, 0), Quaternion.identity);
            GameObject spawnedBrickR4 = Instantiate(blueBrick, greenSpawnPos + new Vector3(i * 2, blueSpawnPos.y, 0), Quaternion.identity);
            GameObject spawnedBrickR5 = Instantiate(purpleBrick, greenSpawnPos + new Vector3(i * 2, purpleSpawnPos.y - 0.75f, 0), Quaternion.identity);
            GameObject spawnedBrickR6 = Instantiate(purpleBrick, greenSpawnPos + new Vector3(i * 2, purpleSpawnPos.y, 0), Quaternion.identity);
            GameObject spawnedBrickR7 = Instantiate(redBrick, greenSpawnPos + new Vector3(i * 2, redSpawnPos.y - 0.75f, 0), Quaternion.identity);

            // Set parent transform to keep hierarchy clean
            spawnedBrickR1.transform.parent = transform;
            spawnedBrickR2.transform.parent = transform;
            spawnedBrickR3.transform.parent = transform;
            spawnedBrickR4.transform.parent = transform;
            spawnedBrickR5.transform.parent = transform;
            spawnedBrickR6.transform.parent = transform;
            spawnedBrickR7.transform.parent = transform;
        }
    }

    
    // Spawn Ball
    void SpawnBall()
    {
        ballObj.SetActive(true);
        Vector3 ballPos = ballObj.transform.position;
        resetBallPos = ballPos;
        GameObject spawnedBall = Instantiate(ballObj, ballPos, Quaternion.identity);
    }


    // Spawn Paddle
    void SpawnPaddle()
    {
        Vector3 paddlePos = paddle.transform.position;
        GameObject paddleSpawn = Instantiate(paddle, paddlePos, Quaternion.identity);
    }


    // Spawn top bound object
    void SpawnTopBound()
    {
        Vector3 topBoundPos = topBound.transform.position;
        GameObject spawnTopBound = Instantiate(topBound, topBoundPos, Quaternion.identity);
    }



    // Activate GameOver scene
        // After getting ball movement working,
        // see if ballObj.SetActive(false) will
        // work by --> if gameOverOverlay is true,
        // then disable
    public void GameOver()
    {
        if (playerData.life == 0)
        {
            gameOverOverlay.SetActive(true);
            gameOverScore.text = "Score: " + playerData.score;
            //ballObj.SetActive(false);
        }
    }


    // Respawn ball Coroutine
    public IEnumerator ResetBallTimer()
    {
        ballObj.SetActive(false);
        yield return new WaitForSeconds(4.0f);
        ballObj.SetActive(true);
        InitialSpeed();
        Debug.Log("Started Coroutine");
    }


    // Reset ball on death with Coroutine
    public void ResetBall()
    {
        StartCoroutine(ResetBallTimer());
    }

    // Disable ball at end of scene (applied in Ball script)
        // Couldn't get this to work
    public void DisableBall()
    {
        ballObj.SetActive(false);
        Debug.Log("Ball disabled");
    }


    // Get inital speed for respawning
    public void InitialSpeed()
    {
        Ball ball = ballObj.GetComponent<Ball>();
        float initialSpeed = ball.speed;
        ball.speed = initialSpeed;
    }



}
