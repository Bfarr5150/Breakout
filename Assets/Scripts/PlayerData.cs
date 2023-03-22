using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int score;
    public int life;

    private void Start()
    {
        score = 0;
        life = 0;
    }
}
