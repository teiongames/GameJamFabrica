using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int health = 10;
   // public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
               player.TakeDamage(10);  
        }
    } 
    void Die()
    {
    //    Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

