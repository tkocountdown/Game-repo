﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;


using UnityEngine;



public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public static float speed = 1;
    private Transform target;
    public GameObject enemy;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
}
