using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private Stats health;

    private void Awake()
    {
        health.Initialize();
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            TakeDamage(10);
        }
    }


public void TakeDamage(int damage)
{
        health.CurrentVal -= 10;

    if (health.CurrentVal <= 0)
    {
            //gameover
            Destroy(gameObject);
            //passa pra cena
    }
}

// Update is called once per frame
void Update() {

}
}