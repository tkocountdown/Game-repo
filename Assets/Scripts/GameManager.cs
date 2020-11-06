using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int lives = 2;
    public static bool playGame = true;
    public Text livesText;
    public Text endScrene;
    float timer = 0;
    float timeToMove = 0.5f;
    int moveCounter = 0;
    void Start()
    {
        livesText.text = "Lives" + lives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives:" + lives;
        if (lives == 0)
        {
            endScrene.text = " You Lose";
            playGame = false;
        }
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
           
            timer = 0;
            moveCounter++;

        }
        if (moveCounter > 40 && moveCounter<60)
        {
            EnemySpawner.spawnRate = 1f;
        }
        else if(moveCounter>60)
        {
            EnemySpawner.spawnRate = 50f;
        }
    }
}
