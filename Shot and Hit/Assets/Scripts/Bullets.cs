using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float damage = 20f;

    void Update()
    {
        BulletMoove();
    }

    public void DealDamage(ICanBeDamaged tm)
    {
        tm.TakeDamage(damage);
    }

    void Die()
    {
        Destroy(gameObject);
    }
       

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (!collisionInfo.collider.gameObject.TryGetComponent<ICanBeDamaged>(out ICanBeDamaged damageable)) return;
        DealDamage(damageable);
        Destroy(gameObject);
        
    }

    private void BulletMoove()
    {
        transform.position += transform.up * speed * Time.deltaTime;   
    }
}
