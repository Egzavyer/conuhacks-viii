using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviour : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    GunSpecs gunSpecs;
    public float bulletSpeed;
    public float rateOfFire;
    PlayerMovement playerMovement;

    void Start()
    {
        rateOfFire = GunSpecs.rateOfFire;
        bulletSpeed = GunSpecs.bulletSpeed;
        InvokeRepeating(nameof(Shoot), 0, rateOfFire);
    }

    void Shoot()
    {
        if (!PlayerMovement.isWalking)
        {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
        }
    }
}