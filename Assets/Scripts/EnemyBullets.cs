using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
    public float timebetweenshot;
    public float nextshot = -1;
    public GameObject bullet;

    void Start()
    {
        nextshot = Random.Range(1, 3);
        timebetweenshot = Random.Range(3, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextshot)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextshot = Time.time + timebetweenshot;
        }
    }
}
