using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;


using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.2f;
    public GameObject enemyprojectile;
    public GameObject enemyprojectileClone;
    public GameObject enemy;
    //float lifecount = 0;
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        // moving down after 10 intervals
        if (GameManager.playGame)
        {
            //an attempt to give player an extra life if they can survive at 3 lives for 10 seconds.
            //lifecount += Time.deltaTime;
         //   if (lifecount==10 && GameManager.lives==3)
          //  {
           //     GameManager.lives = 4;
            //    lifecount = 0;
           // }
            if (numOfMovements == 10)
            {
               
                transform.Translate(new Vector3(0, -1, 0));
                numOfMovements = -1;
                speed = -speed;
                timer = 0;
                
                

            }
            // moving sideways on timed intervals.
            timer += Time.deltaTime;
            if (timer > timeToMove && numOfMovements < 10)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
                numOfMovements++;
                
            }
            fireEnemyProjectile();
        }
    }
        

    void fireEnemyProjectile()
        {
            // had to use UnityEngine.Random because of unity having to possible cases and being unable to differentiate the two
            if(UnityEngine.Random.Range(0f,5000f) < 1)
            {
                enemyprojectileClone = Instantiate(enemyprojectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.4f, 0), enemy.transform.rotation) as GameObject;
            }
        }
    
}
