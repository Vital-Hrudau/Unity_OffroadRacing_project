using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class carcontrol : MonoBehaviour { // скрипт управления нивой

    public WheelJoint2D[] wheels;
    public float horizont;
    public int HPniva;
    public GameObject carbody, Niva;
    public int fuelSize;
    public  float fuelUsege;
    private float currentFuel;
    public GameObject fuelProgressBar, finishText;
    public Text scoreText, rubinText; 
    private int scoreInt, rubinInt;
    public GameObject outoffuel, forward, back;
    //бензометр ниже
    public float _start; // начальное положение стрелки по оси Z

    public float maxSpeed; // максимальная скорость на спидометре

    public RectTransform arrow; // стрелка спидометра

    public enum ProjectMode { Project3D = 0, Project2D = 1 };
    public ProjectMode projectMode = ProjectMode.Project3D;

    public Transform target; // объект с которого берем скорость

    public float velocity; // текущее реальное колво топлива объекта

    private Rigidbody _3D;
    private Rigidbody2D _2D;
    private float speed;
    public float benz;


    void Start()
    {
        scoreInt = PlayerPrefs.GetInt("score");
        rubinInt = PlayerPrefs.GetInt("rubin");
        arrow.localRotation = Quaternion.Euler(0, 0, _start);
        benz = 0.85f;
        wheels = gameObject.GetComponents<WheelJoint2D>();
        currentFuel = fuelSize;
        HPniva = PlayerPrefs.GetInt("HPniva");
        //currentFuel = PlayerPrefs.GetFloat("FuelNiva");
        fuelUsege = 0.6f;
        if (!PlayerPrefs.HasKey("HPniva"))
        {
            PlayerPrefs.SetInt("HPniva", 1000);
        }
    }
  
    public void Forward()
    {
         horizont = 1f;
        currentFuel -= fuelUsege * Time.deltaTime;
        fuelUsege = 1.5f;
        forward.transform.localScale = new Vector3(0.89f, 0.89f, 0.89f);

    }
    public void Back()
    {
         horizont = -1f;
        currentFuel -= fuelUsege * Time.deltaTime;
        fuelUsege = 1.5f;
        back.transform.localScale = new Vector3(0.89f, 0.89f, 0.89f);

    }
    public void ForwardUp()
    {
        horizont = 0f;
        fuelUsege =1.0f;
        forward.transform.localScale = new Vector3(1f, 1f, 1f);

    }
    public void BackUp()
    {
        horizont = 0f;
        fuelUsege = 1.0f;
        back.transform.localScale = new Vector3(1f, 1f, 1f);

    }

    public void Update()
    {    
        PlayerPrefs.SetInt("score", scoreInt);
        PlayerPrefs.SetInt("rubin", rubinInt);
        PlayerPrefs.SetInt("HPniva", HPniva);
        scoreText.text = scoreInt.ToString();
        rubinText.text = rubinInt.ToString();
        fuelProgressBar.transform.localScale = new Vector2(currentFuel / fuelSize, 1);
        //бензометр
        //if (currentFuel > maxSpeed) currentFuel = maxSpeed;
        //benz = benz - 0.01f;
        speed = _start - currentFuel; // 
        arrow.localRotation = Quaternion.Euler(0, 0, speed);
        //
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
        else {
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
        if (currentFuel <= 0)
        {
            horizont = 0;
            outoffuel.SetActive(true);
            return;
        }
        else outoffuel.SetActive(false);
        if (currentFuel <= 35)
        {
            fuelProgressBar.GetComponent<Image>();
        }
        currentFuel -= fuelUsege * Time.deltaTime;
        //print(currentFuel);

        PlayerPrefs.SetFloat("ObjX", gameObject.transform.position.x);
        PlayerPrefs.SetFloat("ObjY", gameObject.transform.position.y);
    }
     void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "coins")
        {
            scoreInt = PlayerPrefs.GetInt("score");
            scoreInt= scoreInt +1;
            Destroy(trigger.gameObject);
        }
        if ( trigger.gameObject.tag == "fuel")
        {
            currentFuel = 90;
            Destroy(trigger.gameObject);
        }
      
        if (trigger.gameObject.tag == "rubin")
        {
            rubinInt = PlayerPrefs.GetInt("rubin");
            rubinInt++;
            //rubinInt = rubinInt + 1;
            Destroy(trigger.gameObject);
        }
        if (trigger.gameObject.tag == "teleport1")
        {
            Niva.transform.localPosition = new Vector3(-98f, 15f);
            scoreInt = scoreInt + 400;
        }
        if (trigger.gameObject.tag == "finish")
        {
            horizont = 0;
            finishText.SetActive(true);
            //Niva.transform.localPosition = new Vector3(1f, 1f);
            scoreInt = scoreInt + 400;
            
        }
    }
}

