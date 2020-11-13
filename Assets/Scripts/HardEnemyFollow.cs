using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;


using UnityEngine;



public class HardEnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public static float hardSpeed = 7;
    private Transform target;
    public GameObject enemyHard;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, hardSpeed * Time.deltaTime);

        }
    }
}
