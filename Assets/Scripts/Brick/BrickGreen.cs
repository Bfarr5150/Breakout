using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGreen : Brick
{
    [Header("Private brick speed variable")]
    [SerializeField]
    private float speed = 1.0f;

    // Ability to assign material to prefab in inspector
    public Material BrickGreenMat;

    void Start()
    {
        brickMaterial = GetComponent<Renderer>().material;
        brickSpeed = speed;
        brickScore = 250;
    }
}
