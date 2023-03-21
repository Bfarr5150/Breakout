using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGreen : Brick
{
    [Header("Private brick speed variable")]
    [SerializeField]
    private float speed = 1.0f;

    public Material BrickGreenMat;

    void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 250;
    }
}
