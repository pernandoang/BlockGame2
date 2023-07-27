using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int points = 1;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        ScoreManager.instance.AddScore(points);
        Destroy(gameObject);
    }
}
