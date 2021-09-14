using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetModule : MonoBehaviour
{
    [SerializeField]public float maxHealth = 100f;
    private float curHealth;

    public bool IsDead { get; private set; } = false;

    private void Start()
    {
        ResetHp();
    }

    private void ResetHp()
    {
        curHealth = maxHealth;
    }

    public void TakeDamage(float dmg)
    {
        curHealth -= dmg;
        if (curHealth <= 0 && !IsDead)
        {
            IsDead = true;
            curHealth = 0;
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
