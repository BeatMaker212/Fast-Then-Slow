using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBOOM : MonoBehaviour
{
    public GameObject bomb;
    public float power = 10f;
    public float radius = 5f;
    public float upforce = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("b"))
        {
            Contact();
        }


    }

    public void Contact()
    {
        Vector3 explosionPosition = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddExplosionForce(power, explosionPosition, radius, upforce, ForceMode.Impulse);
        }
    }
}
