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

    float minS = 0;
    float maxS = 1;

    void Update()
    {
        if(timeBetwnSpawn <= 0)
        {
            float randomLocation = Random.Range(minS, maxS);
            transform.position = new Vector3(transform.position.x, transform.position.y + randomLocation, transform.position.z);
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
