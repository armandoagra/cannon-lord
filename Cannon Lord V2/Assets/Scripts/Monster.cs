using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    public float currentHp;
    int direction;
    public float horizontalSpeed;
    public float verticalSpeed;
    public int points;
    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        direction = Random.Range(1, 3);
        if (direction % 2 == 0)
        {
            direction = 1;
        }
        else {
            direction = -1;
        }

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector2.down * verticalSpeed + Vector2.right * direction * horizontalSpeed) * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cannonball"))
        {
            TakeDamage(1);
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Wall"))
        {
            direction = direction * -1;
        } else if (collision.CompareTag("Base"))
        {
            GameManager.instance.GameOver();
        }
    }

    void TakeDamage(int amount)
    {
        currentHp -= amount;
        if (currentHp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<AudioSource>().Play();
        anim.SetTrigger("Death");
        verticalSpeed = 0;
        horizontalSpeed = 0;
        GameManager.instance.AddScore(points);
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, 1f);


    }
}
