using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 10, 0);
    }
}
