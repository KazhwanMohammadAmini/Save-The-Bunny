using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;

    public float xPositionLimit;
    public float spawnRate;


    void Start()
    {
        //SpawnEnemy();
        StartSpawning();
    }

    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float radomX = Random.Range(-xPositionLimit, xPositionLimit);

        Vector2 spawnPosition = new Vector2(radomX, transform.position.y);
        
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }

    public void StartSpawning ()
    {

        InvokeRepeating("SpawnEnemy", 1f, spawnRate);

    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnEnemy");
    }
}
