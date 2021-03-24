using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontControl : MonoBehaviour
{

    public WheelJoint2D[] wheels;
    public float horizont;
    public int HPfront;
    public GameObject carbody, Frontera;
    public int fuelSize;
    public float fuelUsege;
    private float currentFuel;
    public GameObject fuelProgressBar;
    public Text scoreText, rubinText;
    public int scoreInt, rubinInt;
    public GameObject outoffuel, forward, back;
    //
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


    void Start()
    {
        wheels = gameObject.GetComponents<WheelJoint2D>();
        //HPfront = 1100;
        currentFuel = fuelSize;
        scoreInt = PlayerPrefs.GetInt("score");
        rubinInt = PlayerPrefs.GetInt("rubin");
        HPfront = PlayerPrefs.GetInt("HPfront");
        //currentFuel = PlayerPrefs.GetFloat("FuelNiva");
        fuelUsege = 0.8f;
        arrow.localRotation = Quaternion.Euler(0, 0, _start);
    }
    public void Forward()
    {
        horizont = 1f;
        currentFuel -= fuelUsege * Time.deltaTime;
        fuelUsege = 1.9f;
        forward.transform.localScale = new Vector3(0.89f, 0.89f, 0.89f);
        //Frontera.transform.Rotate(new Vector3(0, 0, z:6), Space.World); проба изменения Rotation при нажатии на газ()
        

    }
    public void Back()
    {
        horizont = -1f;
        currentFuel -= fuelUsege * Time.deltaTime;
        fuelUsege = 1.9f;
        back.transform.localScale = new Vector3(0.89f, 0.89f, 0.89f);

    }
    public void ForwardUp()
    {
        horizont = 0f;
        fuelUsege = 1.0f;
        forward.transform.localScale = new Vector3(1f, 1f, 1f);

    }
    public void BackUp()
    {
        horizont = 0f;
        fuelUsege = 1.0f;
        back.transform.localScale = new Vector3(1f, 1f, 1f);

    }

    void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        PlayerPrefs.SetInt("rubin", rubinInt);
        PlayerPrefs.SetInt("HPfront", HPfront);
        PlayerPrefs.SetFloat("FuelNiva", currentFuel);
        scoreText.text = scoreInt.ToString();
        rubinText.text = rubinInt.ToString();
        fuelProgressBar.transform.localScale = new Vector2(currentFuel / fuelSize, 1);
        speed = _start - currentFuel; // 
        arrow.localRotation = Quaternion.Euler(0, 0, speed);
        if (horizont < -0.8 || horizont > 0.8)
        {
            foreach (WheelJoint2D joint in wheels)
            {
                var motor = joint.motor;
                motor.motorSpeed = HPfront * horizont * -1;
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


private void OnTriggerEnter2D(Collider2D trigger)
{
    if (trigger.gameObject.tag == "fuel")
    {
        currentFuel = 100;
        Destroy(trigger.gameObject);
    }
    if (trigger.gameObject.tag == "coins")
    {
        scoreInt = PlayerPrefs.GetInt("score");
        scoreInt++;
        //scoreInt = scoreInt + 1;
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
        Frontera.transform.localPosition = new Vector3(-98f, 15f);
        scoreInt = scoreInt + 400;
    }
}
}
