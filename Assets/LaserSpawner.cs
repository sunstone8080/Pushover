using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject laser;

    public Transform[] spawnPoints;


    float nextTimeToSpawn = 0f;



    void SpawnLaser ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];


        Instantiate(laser, spawnPoint.position, spawnPoint.rotation);
        
    }



     void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnLaser();
            nextTimeToSpawn = Time.time + spawnDelay;

        }


        

    }
}
