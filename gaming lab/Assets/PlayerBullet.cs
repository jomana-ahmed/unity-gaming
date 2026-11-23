using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBullet : MonoBehaviour
{
    public float speed;
    public ABShooting player; //a variable that stores the Shooting script that is attached to the Player
    //This can be used as a more elegant alternative to FindObjectOfType<ABShooting>() or FindObjectOfType<PlayerController>()
    public int damage;

    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private float timer = 0;
    private float lifeTime = 2;

    void Start()
    {
        // initialises the sprite renderer and rigidbody of the bullet
        // and accesses the script on the player that shoots the bullet
        player = FindObjectOfType<ABShooting>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        //makes sure the bullet and player are in the same direction
        sr.flipX = player.sr.flipX;
    }

    void Update()
    {
        if (sr.flipX)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        // makes sure the bullet gets destroyed after a few seconds so it doesn't travel
        // FOREVER
        if ((timer += Time.deltaTime) >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

    // Damage to the enemy
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyController>().EnemyTakeDamage(damage);
            Destroy(gameObject);
        }

        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
