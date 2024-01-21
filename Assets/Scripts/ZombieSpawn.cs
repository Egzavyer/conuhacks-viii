using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{
    public Transform zombieSpawnPoint;
    public GameObject zombiePrefab;
    public float spawnRate = 10.0f;
    public int wave;
    public int maxZombie = 4;
    public int zombieCounter = 0;
    void Start()
    {
        wave = GameManager.wave;
        maxZombie += wave;
        InvokeRepeating(nameof(SpawnZombie), 2.0f, spawnRate / wave);
    }

    void SpawnZombie()
    {
        if (zombieCounter < maxZombie)
        {
            zombieSpawnPoint.position = new Vector3(zombieSpawnPoint.position.x, Random.Range(4.0f, -4.0f), 0);
            var zombie = Instantiate(zombiePrefab, zombieSpawnPoint.position, zombieSpawnPoint.rotation);
            zombieCounter += 1;
            Debug.Log(zombieCounter);
        }
        if (zombieCounter == maxZombie && GameObject.Find("Zombie(Clone)") == null)
        {
            Debug.Log("Wave Ended");
            GameManager.NextWave();
        }
    }
}
