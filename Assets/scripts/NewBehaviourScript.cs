using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public WheelJoint2D[] wheels;
    public int horizont;

    void Start()
    {
        wheels = gameObject.GetComponents<WheelJoint2D>();
    }
    public void Update()
    {
        if (Input.GetAxis("Horizontal") < -0.8 || Input.GetAxis("Horizontal") > 0.8) //разделить getAxis на две функции, одна налево, другая направо
                                                                                     //прописать к кнопкам UI через event trigger
        {
            foreach (WheelJoint2D joint in wheels)
            {
                var motor = joint.motor;
                motor.motorSpeed = 1000 * Input.GetAxis("Horizontal") * -1;
                joint.motor = motor;
                joint.useMotor = true;
            }
        }
        else
        {
            foreach (WheelJoint2D joint in wheels)
            {
                var motor = joint.motor;
                motor.motorSpeed = 0;
                joint.motor = motor;
                joint.useMotor = false;
            }
        }
    }
        void FixedUpdate()
    {
            PlayerPrefs.SetFloat("ObjX", gameObject.transform.position.x);
            PlayerPrefs.SetFloat("ObjY", gameObject.transform.position.y);
        }
    }


