using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetModule : MonoBehaviour,  ICanBeDamaged
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private List<DamageTransfer> damageTransfers = new List<DamageTransfer>();
    private float curHealth;

    public bool IsDead { get; private set; } = false;

    private void Start()
    {
        ResetHp();
        SetupDamageTransfers();
    }

    private void SetupDamageTransfers()
    {
        foreach (DamageTransfer transferUnit in damageTransfers)
        {
            transferUnit.SetupDamageTransferUnit(this);
        }
    }

    private void ResetHp()
    {
        curHealth = maxHealth;
    }


    private void Die()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(float damage)
    {
        curHealth -= damage;
        if (curHealth <= 0 && !IsDead)
        {
            IsDead = true;
            curHealth = 0;
            Die();
        }
    }
}
