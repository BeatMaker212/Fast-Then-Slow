using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMobile : MonoBehaviour
{
    public Joystick joyStick;
    public float moveSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        joyStick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joyStick.Horizontal * moveSpeed, rigidbody.velocity.y, joyStick.Vertical * moveSpeed);
    }
}
