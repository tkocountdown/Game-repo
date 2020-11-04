using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR

using UnityEngine;

#endif

public class EnemyProjectile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyProjectile;
    Vector3 respawn = new Vector3(7, 4, 0);
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
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.transform.position = respawn;
            Destroy(enemyProjectile);
            GameManager.lives--;
            GameManager.playGame = false;
        }
        if (collision.gameObject.tag == "Finish")
        {

            Destroy(enemyProjectile);
        }
    }
}
