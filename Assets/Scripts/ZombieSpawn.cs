using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public Transform zombieSpawnPoint;
    public GameObject zombiePrefab;
    public float spawnRate = 10f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnZombie), 0, spawnRate);
    }

    void SpawnZombie()
    {
        zombieSpawnPoint.position = new Vector3(zombieSpawnPoint.position.x, Random.Range(4.0f,-4.0f), 0);
        var bullet = Instantiate(zombiePrefab, zombieSpawnPoint.position, zombieSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = zombieSpawnPoint.right * spawnRate;
    }
}
