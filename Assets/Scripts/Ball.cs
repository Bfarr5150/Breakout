using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    private bool ballCollision = false;
    private bool ballDeath = false;

    [Header("Private ball speed variable")]
    [SerializeField]
    private float ballSpeed;

    // Update is called once per frame
    void Update()
    {
        
    }


    // Ball death check
    bool BallDeathCheck()
    {
        if (ball.transform.position.y < -7)
        {
            return true;
        }
        return false;
    }





}
