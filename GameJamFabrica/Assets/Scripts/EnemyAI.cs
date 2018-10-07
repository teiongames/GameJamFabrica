using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public LayerMask enemyMask;
    public float speed = 10;
    Rigidbody2D enemyBody;
    Transform enemyTrans;
    float enemyWidth, enemyHeight;
    
    void Start()
    {
        enemyTrans = this.transform;
        enemyBody = this.GetComponent<Rigidbody2D>();
        SpriteRenderer mySprite = this.GetComponent<SpriteRenderer>();
        enemyWidth = mySprite.bounds.extents.x;
        enemyHeight = mySprite.bounds.extents.y;
    }

    void FixedUpdate()
    {
        //groundcheck
        Vector2 lineCastPos = enemyTrans.position.toVector2() - enemyTrans.right.toVector2() * enemyWidth + Vector2.up * enemyHeight;
        bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
        bool isBlocked = Physics2D.Linecast(lineCastPos, lineCastPos - enemyTrans.right.toVector2()* .05f, enemyMask);

        if (!isGrounded || isBlocked)
        {
            Vector3 currRot = enemyTrans.eulerAngles;
            currRot.y += 180;
            enemyTrans.eulerAngles = currRot;
        }


        Vector2 myVel = enemyBody.velocity;
        myVel.x = -enemyTrans.right.x* speed;
        enemyBody.velocity = myVel;
    }

    public void Damage (int damage)
    {
       // curHealth -= damage;
        //gameObject.GetComponent<Animation>().Play("Player_Redflash");
    }
}
