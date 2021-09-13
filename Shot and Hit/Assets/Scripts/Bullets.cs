using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float damage = 20f;
    private TargetModule targetModule;

    void Start()
    {
        targetModule = GetComponent<TargetModule>();
    }

    void Update()
    {
        BulletMoove();
    }

    public void TakeDamage()
    {
        Debug.Log(targetModule.health);
        targetModule.health -= damage;
        Debug.Log(targetModule.health);
        if (targetModule.health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        targetModule = GetComponent<TargetModule>();
        Destroy(this.gameObject);
        TakeDamage();
    }

    private void BulletMoove()
    {
        transform.position += transform.up * speed * Time.deltaTime;   
    }
}
