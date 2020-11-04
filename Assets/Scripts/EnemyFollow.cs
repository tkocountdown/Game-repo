using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using System.Security.Cryptography;
#if UNITY_EDITOR

using UnityEngine;

#endif

public class EnemyFollow : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed = 1;
    private Transform target;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
