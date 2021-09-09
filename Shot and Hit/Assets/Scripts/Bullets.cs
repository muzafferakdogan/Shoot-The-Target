using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed = 20f;


    void Start()
    {
        
    }

    void Update()
    {
        BulletMoove();
    }

    private void BulletMoove()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
