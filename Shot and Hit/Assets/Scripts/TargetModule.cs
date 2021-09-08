using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetModule : MonoBehaviour
{
    [SerializeField]private float health = 100f;
    

    public void TakeDamage(float amounth)
    {
        health -= amounth;
        Debug.Log(health);
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
