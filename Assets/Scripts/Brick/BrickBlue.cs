using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlue : Brick
{
    [Header("Private brick speed variable")]
    [SerializeField]
    private float speed = 2.0f;

    public Material brickBlueMat;

    void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 500;
    }
}
