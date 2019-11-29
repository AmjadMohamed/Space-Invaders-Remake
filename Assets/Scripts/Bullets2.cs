using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets2 : MonoBehaviour
{
    public float speed = 5;
    public int damage;
    public GameObject explosion; 


    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, collision.transform.position, Quaternion.identity);
            SoundManager.instance.PlayOneShot(SoundManager.instance.playerExplosion);
            Destroy(fire, 0.2f);
            Destroy(gameObject);
            GameManager.playerdead();
        }
    }

}
