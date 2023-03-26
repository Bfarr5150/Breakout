using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickRed : Brick
{
    [Header("Private brick speed variable")]
    [SerializeField]
    public float speed = 4.0f;

    public Material brickRedMat;

    void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 2500;
    }
}
