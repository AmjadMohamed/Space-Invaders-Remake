using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementspeed = 2;
    

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(movementspeed , 0);
    }

    
    void Update()
    {
        if(transform.position.x >= 6.5)
        {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y - 1);
            movementspeed = -movementspeed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementspeed, 0);
        }

       else if (transform.position.x <= -6.5)
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 1);
            movementspeed = -movementspeed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(movementspeed, 0);
        }
    }
}
