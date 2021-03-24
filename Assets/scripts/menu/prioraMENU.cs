using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prioraMENU : MonoBehaviour {


    public WheelJoint2D[] wheels;
    public float horizont;




    void Start()
    {
        wheels = gameObject.GetComponents<WheelJoint2D>();
        horizont = 1f;

    }

    public void Update()
    {
        horizont = 1f;
        if (horizont < -0.8 || horizont > 0.8)
        {
            foreach (WheelJoint2D joint in wheels)
            {
                var motor = joint.motor;
                motor.motorSpeed = 400 * horizont * -1;
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
}

