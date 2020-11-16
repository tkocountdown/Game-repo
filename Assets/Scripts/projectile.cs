using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;


using UnityEngine;



public class projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Projectile;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(new Vector3(0, -5 * Time.deltaTime, 0));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            Destroy(collision.gameObject);
            Destroy(Projectile);
            PlayerScript.projcounter--;
            Sound.PlaySound("hit");
            GameManager.playGame = true;
        }
        if (collision.gameObject.tag == "Finish")
        {
            
            Destroy(Projectile);
            PlayerScript.projcounter--;
        }
       
       
    }
}
