using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour
{
    //public float timebetweenshot;
   // public float nextshot = -1;
    public GameObject bullet;

    /*void Start()
     {
         nextshot = Random.Range(1, 2);
         timebetweenshot = Random.Range(2, 3);
     }*/
    
     void Update()
     {
        /* if (Time.time > nextshot)
          {
            
            nextshot = Time.time + timebetweenshot;
          }*/

        Instantiate(bullet, transform.position, Quaternion.identity);


    }

 
}
