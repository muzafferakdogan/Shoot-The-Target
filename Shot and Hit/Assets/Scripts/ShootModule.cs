using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootModule : MonoBehaviour
{
    [SerializeField] private float damage = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("sa");

        TargetModule targetModule = GetComponent<TargetModule>();

        if (targetModule != null)
        {
            targetModule.TakeDamage(damage);
        }
    }
}
