using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlue : Brick
{
    public float speed = 2.5f;
    public Material brickBlueMat;

    private void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 500;
    }
}
