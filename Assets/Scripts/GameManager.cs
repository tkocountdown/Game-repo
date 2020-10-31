using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static int lives = 3;
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
        livesText.text = "Lives" + lives;
        if (lives == 0)
        {
            endScrene.text = " You Lose";
        }
        timer += Time.deltaTime;
        if (timer > timeToMove)
        {
           
            timer = 0;
            moveCounter++;

        }
        if (lives==3 && moveCounter == 20)
        {
            lives++;
        }
    }
}
