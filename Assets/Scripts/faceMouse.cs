using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;


using UnityEngine;



public class faceMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FaceMouse();
    }
    void FaceMouse()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        Vector3 direction = new Vector3(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);
        transform.up = direction;
    }
}
