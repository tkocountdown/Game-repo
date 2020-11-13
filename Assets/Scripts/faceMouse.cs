using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;


using UnityEngine;



public class faceMouse : MonoBehaviour
{
    // Start is called before the first frame update
    int angleOffset = -90;

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
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + angleOffset;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Vector3 mouseposition = Input.mousePosition;
        //mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        //Debug.Log(mouseposition);
        //Vector2 direction = new Vector2(mouseposition.x - transform.position.x, mouseposition.y - (transform.position.y));
        //Debug.Log(direction);
        //transform.up = direction;
       
    }
}
