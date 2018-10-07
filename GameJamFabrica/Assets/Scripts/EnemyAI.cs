using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {


    void awake()
    {
        //anim = gameObject.GetComponent<Animator>();
    }

    void Start()
    {
       // curHealth = maxHealth;
    }

    void update()
    {
        
       // if (curHealth <= 0)
       // {
       //     Destroy(gameObject);
      //  }
    }

    public void Damage (int damage)
    {
       // curHealth -= damage;
        //gameObject.GetComponent<Animation>().Play("Player_Redflash");
    }
}
