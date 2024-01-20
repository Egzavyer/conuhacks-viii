using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieType : MonoBehaviour

{
    public string zombieType = "Normal";
    public float health = 3f;
    public float damage;
    GunSpecs gunSpecs;
    // Start is called before the first frame update
    void Start()
    {
        damage = GunSpecs.bulletDamage;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
        {
            if (collision.gameObject.CompareTag("Bullet")) {
                health -= damage;
            }
            
        }
}
