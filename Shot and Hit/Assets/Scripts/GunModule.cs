using UnityEngine;

public class GunModule : MonoBehaviour
{
    [SerializeField]private float damage = 20f;
    [SerializeField]private float range = 100f;

    [SerializeField]private Camera fpsCam;

    private void Start()
    {

    }

    private void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            TargetModule taretModule = hit.transform.GetComponent<TargetModule>();

            if (taretModule != null)
            {
                taretModule.TakeDamage(damage);
            }
        }
    }
}
