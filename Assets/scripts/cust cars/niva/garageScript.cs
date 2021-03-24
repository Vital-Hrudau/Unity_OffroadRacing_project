using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class garageScript : MonoBehaviour
{ //скрипт гаража нивы

    public Text motorhp, Bak;
    private int HPniva;
    private float currentFuel;
    private int updateHPniva1, updBenzNiva1;
    private int scoreInt;
    public GameObject UpdButton1;
    public GameObject UpdButton2;
    public GameObject UpdButton3;
    public GameObject FinalButton;
    public GameObject BenzButt1;
    public GameObject BenzButt2;
    public GameObject BenzButt3;
    public GameObject BenzFinal;


    public void Start()
    {
        if (!PlayerPrefs.HasKey("updateHPniva1"))
        {
            PlayerPrefs.SetInt("updateHPniva1", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        if (!PlayerPrefs.HasKey("updBenzNiva1"))
        {
            PlayerPrefs.SetInt("updBenzNiva1", 0);
        }
        currentFuel = PlayerPrefs.GetFloat("FuelNiva");
        HPniva = PlayerPrefs.GetInt("HPniva");
        updateHPniva1 = PlayerPrefs.GetInt("updateHPniva1");
        scoreInt = PlayerPrefs.GetInt("score");
        //updateHPniva1 = 0;
        if (updateHPniva1 == 0)
        {
            HPniva = 800;
            UpdButton1.SetActive(true);
            //UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 1.5 л, 80 л.с.");
        }
            if (updateHPniva1 == 1)
        {
            HPniva = 1100;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 1.6 л, 90 л.с.");
        }
        if (updateHPniva1 == 2)
        {
            HPniva = 1200;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            motorhp.text = ("Мотор: 1.8 л, 103 л.с.");
        }
        if (updateHPniva1 == 3)
        {
            HPniva = 1250;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 2.0 л, 125 л.с.");
        }
        if (updBenzNiva1 == 1)
        {
            BenzButt1.SetActive(false);
            Bak.text = ("Объем бака: 52 л");
            currentFuel = currentFuel +10;
        }
    }
    private void Update()
    {
        PlayerPrefs.SetInt("HPniva", HPniva);
        HPniva = PlayerPrefs.GetInt("HPniva");
        PlayerPrefs.SetInt("updateHPniva1", updateHPniva1);
        updateHPniva1 = PlayerPrefs.GetInt("updateHPniva1");
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        //PlayerPrefs.SetFloat("FuelNiva", currentFuel);
       // currentFuel = PlayerPrefs.GetInt("FuelNiva");
        //PlayerPrefs.SetFloat("updBenzNiva1", updBenzNiva1);
       // updBenzNiva1 = PlayerPrefs.GetInt("updBenzNiva1");


    }

    public void toMaps()
    {
        SceneManager.LoadScene(5);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(2);
    }
    public void UpdateMotor1()
    {
        if (scoreInt >= 150)
        {
            scoreInt = scoreInt - 150;
            motorhp.text = ("Мотор: 1.6 л, 90 л.с.");
            updateHPniva1 = 1;
            HPniva = 900;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.1");
        }
        if (scoreInt < 150)
        {
            print("Недостаточно средств");
        }

    }
    public void UpdateMotor2()
    {
        if (scoreInt >= 250)
        {
            scoreInt = scoreInt - 250;
            motorhp.text = ("Мотор: 1.8 л, 103 л.с.");
            updateHPniva1 = 2;
            HPniva = 1030;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
        }
        if (scoreInt < 250)
        {
            print("Недостаточно средств");
        }
    }
    public void UpdateMotor3()
    {
        if (scoreInt >= 400)
        {
            scoreInt = scoreInt - 400;
            motorhp.text = ("Мотор: 2.0 л, 125 л.с.");
            updateHPniva1 = 3;
            HPniva = 1250;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.3");
        }
        if (scoreInt < 400)
        {
            print("Недостаточно средств");
        }
    }
    public void UpdateBenz1()
    {
        if (scoreInt >= 50)
        {
            scoreInt = scoreInt - 50;
            Bak.text = ("Объем бака: 52 л");
            updBenzNiva1 = 1;
            currentFuel = 52;
            PlayerPrefs.Save();
            print("Бензобак ур.1");
        }
        if (scoreInt < 50)
        {
            print("Недостаточно средств");
        }
    }
}

