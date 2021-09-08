using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    [SerializeField] private float range = 100f;

    [SerializeField]private Transform FirePoint;
    [SerializeField]private GameObject BulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);

    }
}
