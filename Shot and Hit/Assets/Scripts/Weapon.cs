using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float range = 100f;

    [SerializeField]private Transform FirePoint;
    [SerializeField]private GameObject BulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreateBullet();
        }
        
    }
    
    void CreateBullet()
    {
        Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);

    }


}
