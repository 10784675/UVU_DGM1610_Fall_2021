using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemies;
    public GameObject powerup;
    public GameObject obstacle;
    private float xSpawnRange = 20.0f;
    private float zEnemySpawn = 20.0f;
    private float zPowerupRange = 20.0f;
    private float ySpawn = 0.75f;
    private float startDelay = 1.0f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
        InvokeRepeating("SpawnPowerup", startDelay, spawnInterval);
    }

    void Update()
    {

    }
    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);
        Instantiate(enemies, spawnPos, enemies.gameObject.transform.rotation);
    }

    void SpawnRandomObstacle()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);
        Instantiate(obstacle, spawnPos, obstacle.gameObject.transform.rotation);
    }
    void SpawnPowerUp()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }

}