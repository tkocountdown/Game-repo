using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public GameObject projectile;
    public GameObject projectileClone;
    private int projcounter = 0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.lives > 0)
        {
            movement();
            fireProjectile();
        }
    }
    void movement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(5 * Time.deltaTime, 0, 0));

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-5 * Time.deltaTime, 0, 0));

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));

        }
    }
    void fireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& projcounter < 4)
        {
            projectileClone = Instantiate(projectile, new Vector3(Player.transform.position.x, Player.transform.position.y , 0), Player.transform.rotation) as GameObject;
            projcounter++;
        }
    }
}
