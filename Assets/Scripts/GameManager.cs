using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int lives = 2;
    public static bool playGame = true;
    public Text livesText;
    public Text endScrene;
    //public Text shotCount;
    float timer = 0;
    float timeToMove = 0.5f;
    int moveCounter = 0;
   // int getBulltet = 5;
   // int bulletstime = 0;
    //public static int shotcount = 1;
    

    void Start()
    {
        livesText.text = "Lives" + lives;
        //shotCount.text = "Bullets Available:" + shotcount;
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
        if (moveCounter == 40)
        {
            Sound.PlaySound("dif");
        }
        else if (moveCounter == 60)
        {
            Sound.PlaySound("dif");
        }
        else if (moveCounter == 100)
        {
            Sound.PlaySound("dif");

        }
        else if(moveCounter == 320)
        {
            Sound.PlaySound("dif");
        }
               
        if (moveCounter > 40 && moveCounter<60)
        {
            EnemySpawner.spawnRate = 8f;
            EnemySpawner.hardSpawnRate = 300f;
            EnemyFollow.speed = 2;
            
        }
        else if(moveCounter > 60 && moveCounter < 100)
        {
            EnemySpawner.hardSpawnRate = 300f;
            EnemySpawner.spawnRate = 6f;
            EnemyFollow.speed = 3;
            
        }
        else if (moveCounter > 100 && moveCounter < 180)
        {
            EnemySpawner.hardSpawnRate = 15f;
            EnemySpawner.spawnRate = 4f;
            EnemyFollow.speed = 4;
            
        }
        else if (moveCounter > 320)
        {
            EnemySpawner.hardSpawnRate = 10f;
            EnemySpawner.spawnRate = 2f;
            EnemyFollow.speed = 5;
            
        }
    }
}
