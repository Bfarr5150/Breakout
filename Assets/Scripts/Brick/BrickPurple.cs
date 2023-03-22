using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickPurple : Brick
{
    [Header("Private brick speed variable")]
    [SerializeField]
    private float speed = 3.0f;

    public Material brickPurpleMat;

    void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 1150;
    }
}
