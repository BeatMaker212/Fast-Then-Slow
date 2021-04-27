using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlayerMove : MonoBehaviour
{
    public Joystick joyStick;
    // Start is called before the first frame update
    void Start()
    {
        joyStick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidBody = GetComponent<Rigidbody>();

        rigidBody.velocity = new Vector3(joyStick.Horizontal * 100f, rigidBody.velocity.y, joyStick.Vertical * 100f);
    }
}
