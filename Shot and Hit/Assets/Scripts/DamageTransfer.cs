using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTransfer : MonoBehaviour, ICanBeDamaged
{
    [SerializeField] private float damageMultiplier = 1;
    private ICanBeDamaged damageable;
    public void TakeDamage(float damage)
    {
        damageable.TakeDamage(damage * damageMultiplier);
    }

    public  void SetupDamageTransferUnit(ICanBeDamaged _damageable)
    {
        damageable = _damageable;
    }
}
