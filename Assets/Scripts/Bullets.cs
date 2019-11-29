using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
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
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            GameObject fire = (GameObject)Instantiate(explosion, collision.transform.position, Quaternion.identity);
            SoundManager.instance.PlayOneShot(SoundManager.instance.EnemyExplosion);
            Destroy(fire, 0.1f);
            ScoreSystem.UpdateScore();
            Destroy(gameObject);
        }
    }

}
