using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;

    private float timeBetwnSpawn;
    public float startTime = 2;
    public float decTime = 0.1f;
    float minTime = 0.69f;

    public float minS = -3;
    public float maxS = 1;

    private IEnumerator Start()
    {
         this.enabled = false; // Disable us while waiting
 
         // Wait for input
         while (!Input.anyKey)
         {
             yield return null;
         }
 
         this.enabled = true; // Enable us now
     }

    void Update()
    {
        if(timeBetwnSpawn <= 0)
        {
            float randomLocation = Random.Range(minS, maxS);
            transform.position = new Vector3(transform.position.x, randomLocation, transform.position.z);
            Instantiate(Enemy, transform.position, Quaternion.identity);
            timeBetwnSpawn = startTime;
            if(startTime > minTime) {
                startTime -= decTime;
            }
        } else {
            timeBetwnSpawn -= Time.deltaTime;
        }
    }



}
