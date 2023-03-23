using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public int score;
    public int life;
    private int highscore;

    private void Start()
    {
        score = 5100;
        life = 3;
    }

    public int LifeTest(int life)
    {
        life = 500;
        life--;
        return life;
    }


}
