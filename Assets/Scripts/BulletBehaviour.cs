using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public GunSpecs gunSpecs;
    public float damage;
    public float rateOfFire;

    void Awake()
    {
        damage = GunSpecs.bulletDamage;
    }
    void Update()
    {
        if (transform.position.x >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
