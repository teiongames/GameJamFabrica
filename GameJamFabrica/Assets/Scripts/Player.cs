using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    
    public Stats health;
     bool invincible = false;
    public int invencitime = 1;

    private void Awake()
    {
        health.Initialize();
    }


    public void TakeDamage(int damage)
    {
        if (!invincible)
        {
            health.CurrentVal -= 10;
            invincible = true;
            Invoke("resetinvincible", invencitime);
        }
        if (health.CurrentVal <= 0)
        {
                //gameover
                Destroy(gameObject);
                //passa pra cena
        }
    }

    void resetinvincible()
    {
        invincible = false;
    }
// Update is called once per frame
void Update() {

}
}