using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    float currentHp;
    int direction;
    public float horizontalSpeed;
    public float verticalSpeed;
    public int points;

    private void Awake()
    {
        //direction = Random.
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
        GameManager.instance.AddScore(points);
        Destroy(gameObject);

    }
}
