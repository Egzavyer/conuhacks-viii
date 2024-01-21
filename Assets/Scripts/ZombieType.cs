using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieType : MonoBehaviour

{
    public string zombieType = "Normal";
    public float health = 3f;
    public float damage;
    GunSpecs gunSpecs;
    Rigidbody2D zombieRB;
    public Animator animatorZombie;
    public bool isDying = false;
    // Start is called before the first frame update
    void Start()
    {
        zombieRB = GetComponent<Rigidbody2D>();
        zombieRB.constraints = RigidbodyConstraints2D.FreezeRotation;
        damage = GunSpecs.bulletDamage;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && !isDying)
        {
            isDying = true;
            animatorZombie.SetBool("isDead", true);
            StartCoroutine(WaitForDeath());
            //GameManager.cash += (10 * (GameManager.wave / 2));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= damage;
            animatorZombie.SetBool("isHit", true);
            StartCoroutine(ResetIsHit());
        }
    }
    private IEnumerator ResetIsHit()
    {
        yield return new WaitForSeconds(0.1f);
        animatorZombie.SetBool("isHit", false);
    }

    private IEnumerator WaitForDeath()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOverLine"))
        {
            GameManager.GameOver();
        }
    }
}
