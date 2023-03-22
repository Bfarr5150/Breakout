using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public PlayerData playerData;

    // Spawn variables
    public GameObject greenBrick;
    public GameObject blueBrick;
    public GameObject purpleBrick;
    public GameObject redBrick;
    public GameObject ball;
    public GameObject paddle;

    public TextMeshProUGUI gameOverScore;
    public GameObject gameOverOverlay;

    // DEBUGGING


    void Start()
    {
        SpawnBricks();
        SpawnBall();
        SpawnPaddle();
        

    }

    void Update()
    {
        //GameOver();
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
        Vector3 ballPos = ball.transform.position;
        GameObject spawnedBall = Instantiate(ball, ballPos, Quaternion.identity);
    }


    // Spawn Paddle
    void SpawnPaddle()
    {
        Vector3 paddlePos = paddle.transform.position;
        GameObject paddleSpawn = Instantiate(paddle, paddlePos, Quaternion.identity);
    }

    public void GameOver()
    {
        /*
        if (playerData.life == 0)
        {
            gameOverOverlay.SetActive(true);
            gameOverScore.text = "Score: " + playerData.score;
        }
        */
        gameOverOverlay.SetActive(true);
        gameOverScore.text = "Score: " + playerData.score;

    }



}
