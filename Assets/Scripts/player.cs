using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Vector2 amjad;
    public float movementspeed = 10;
    public GameObject bullet;
    void Start()
    {
        amjad = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity =new Vector2(Input.GetAxis("Horizontal") * movementspeed, Input.GetAxis("Vertical") * movementspeed);

        if(Input.GetButtonDown("Jump"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            SoundManager.instance.PlayOneShot(SoundManager.instance.alienbuzz1);
        }

        if(transform.position.x >= 6.5 || transform.position.x <= -6.5 || transform.position.y >= 4.7 || transform.position.y <= -4.7)
        {
           transform.position = amjad ; 
        }
    }
}
