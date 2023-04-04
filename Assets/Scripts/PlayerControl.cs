using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float paddleSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        
    }

    // Input.GetAxis("Horizontal") * paddleSpeed * Time.deltaTime;
}
