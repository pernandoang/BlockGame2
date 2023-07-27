using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoin;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }  
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, FirePoin.position, FirePoin.rotation);
    }
}
