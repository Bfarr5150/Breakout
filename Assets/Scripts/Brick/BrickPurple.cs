using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickPurple : Brick
{
    public float speed = 3.0f;

    public Material brickPurpleMat;

    void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 1150;
    }
}
