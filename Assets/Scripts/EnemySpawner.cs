using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;


using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    float randX;
    Vector3 whereToSpawn;
    public static float spawnRate = 5f;
    float nextSpawn = 0.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {

            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randX = UnityEngine.Random.Range(-6f, 6f);
                whereToSpawn = new Vector3(randX, transform.position.y);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);


            }
        }
    }
   /* void spawner()
    {
        if (Time.time > nextSpawn && T < 20)
        {
            spawnRate = 5f;
            nextSpawn = Time.time + spawnRate;
            randX = UnityEngine.Random.Range(-6f, 6f);
            whereToSpawn = new Vector3(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            T++;
        }
        else if (Time.time > nextSpawn && T > 20 && T < 50)
        {
            spawnRate = 2f;
            nextSpawn = Time.time + spawnRate;
            randX = UnityEngine.Random.Range(-6f, 6f);
            whereToSpawn = new Vector3(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            T++;
        }
        else
        {
            spawnRate = 1f;
            nextSpawn = Time.time + spawnRate;
            randX = UnityEngine.Random.Range(-6f, 6f);
            whereToSpawn = new Vector3(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            T++;
        }
        
    }*/
}
