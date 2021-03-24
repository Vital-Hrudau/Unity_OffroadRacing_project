using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bmwMenu : MonoBehaviour {

    public WheelJoint2D[] wheels;
    public float horizont;
    public float HPniva;



    void Start()
    {
        wheels = gameObject.GetComponents<WheelJoint2D>();
        HPniva = 470;
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
                motor.motorSpeed = HPniva * horizont * -1;
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
