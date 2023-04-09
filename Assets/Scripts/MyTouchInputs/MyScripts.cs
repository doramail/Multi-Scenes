using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MyScripts : MonoBehaviour
{
    protected Joystick joystick;
    protected MyJoybutton joybutton;
    protected bool jump;
    //public float Horizontal { get; private set; }  
    // Start is called before the first frame update  
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<MyJoybutton>();
    }
    // Update is called once per frame  
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 10.0f + (Input.GetAxis("Horizontal") * 10.0f), rigidbody.velocity.y, joystick.Vertical * 10.0f + Input.GetAxis("Vertical") * 10.0f);
        if (!jump && (joybutton.pressed || Input.GetButton("Fire2")))
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 10.0f;
        }
        if (jump && !joybutton.pressed || Input.GetButton("Fire2"))
        {
            jump = false;
        }
    }
}