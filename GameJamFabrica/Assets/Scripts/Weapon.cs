using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform firePoint;
    public GameObject bulletPf;

    void Update()
    {
        if (Input.GetButtonDown("Ranged")){
            Hit();
        }
            
    }

    void Hit()
    {
        Instantiate(bulletPf, firePoint.position, firePoint.rotation);
    }
}

