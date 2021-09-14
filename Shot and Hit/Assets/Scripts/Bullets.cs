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

    public void DealDamage(TargetModule tm)
    {
        tm.TakeDamage(damage);
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        TargetModule  targetModule = collisionInfo.other.gameObject.GetComponent<TargetModule>();
        DealDamage(targetModule);
        Destroy(gameObject);
    }

    private void BulletMoove()
    {
        transform.position += transform.up * speed * Time.deltaTime;   
    }
}
