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
    public GameManager gameManager;
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

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //zombie takes damage if it is hit by a bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= damage;
            animatorZombie.SetBool("isHit", true);
            StartCoroutine(ResetIsHit());
            //zombie dies if it has no health
            if (health <= 0)
            {
                Destroy(gameObject);
                gameManager.UpdateCash();
            }
        }
    }

    private IEnumerator ResetIsHit()
    {
        //resets the isHit bool in the animator
        yield return new WaitForSeconds(0.1f);
        animatorZombie.SetBool("isHit", false);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        //zombie dies if it hits the game over line
        if (other.gameObject.CompareTag("GameOverLine"))
        {
            GameManager.GameOver();
        }
    }

}
