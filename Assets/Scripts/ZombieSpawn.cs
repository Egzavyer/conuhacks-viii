using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public Transform zombieSpawnPoint;
    public GameObject zombiePrefab;
    public float spawnRate = 10.0f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnZombie), 0, spawnRate);
    }

    void SpawnZombie()
    {
        zombieSpawnPoint.position = new Vector3(zombieSpawnPoint.position.x, Random.Range(4.0f,-4.0f), 0);
        var zombie = Instantiate(zombiePrefab, zombieSpawnPoint.position, zombieSpawnPoint.rotation);
    }
}
