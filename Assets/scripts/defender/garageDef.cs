using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class garageDef : MonoBehaviour
{

    public Text motorhp;
    private int HPDef;
    private int updateHPDef1;
    private int scoreInt, rubinInt;
    public GameObject UpdButton1;
    public GameObject UpdButton2;
    public GameObject UpdButton3;
    public GameObject FinalButton;

    void Start()
    {
        if (!PlayerPrefs.HasKey("updateHPDef1"))
        {
            PlayerPrefs.SetInt("updateHPDef1", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        HPDef = PlayerPrefs.GetInt("HPDef");
        updateHPDef1 = PlayerPrefs.GetInt("updateHPDef1");
        scoreInt = PlayerPrefs.GetInt("score");
        //updateHPDef1 = 0;
        if (updateHPDef1 == 0)
        {
            HPDef = 1200;
            UpdButton1.SetActive(true);
            motorhp.text = ("Мотор: 2.0 л, 120 л.с.");
        }
        if (updateHPDef1 == 1)
        {
            HPDef = 1350;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 2.4 л, 135 л.с.");
        }
        if (updateHPDef1 == 2)
        {
            HPDef = 1480;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            FinalButton.SetActive(false);
            motorhp.text = ("Мотор: 2.8 л, 148 л.с.");
        }
        if (updateHPDef1 == 3)
        {
            HPDef = 1600;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 3.5 л, 160 л.с.");
        }
    }


    void Update()
    {
        PlayerPrefs.SetInt("HPDef", HPDef);
        HPDef = PlayerPrefs.GetInt("HPDef");
        PlayerPrefs.SetInt("updateHPDef1", updateHPDef1);
        updateHPDef1 = PlayerPrefs.GetInt("updateHPDef1");
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
    public void toMaps()
    {
        SceneManager.LoadScene(17);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(15);
    }
    public void UpdateMotor1()
    {
        if (scoreInt >= 250)
        {
            scoreInt = scoreInt - 200;
            motorhp.text = ("Мотор: 2.4 л, 135 л.с.");
            updateHPDef1 = 1;
            HPDef = 1350;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.1");
        }
        if (scoreInt < 250)
        {
            print("Недостаточно средств");
        }
    }
    public void UpdateMotor2()
    {
        if (scoreInt >= 300)
        {
            scoreInt = scoreInt - 300;
            motorhp.text = ("Мотор: 2.8 л, 148 л.с.");
            updateHPDef1 = 2;
            HPDef = 1480;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
        }
        if (scoreInt < 300)
        {
            print("Недостаточно средств");
        }

    }
    public void UpdateMotor3()
    {
        if (scoreInt >= 400)
        {
            scoreInt = scoreInt - 300;
            motorhp.text = ("Мотор: 3.5 л, 160 л.с.");
            updateHPDef1 = 2;
            HPDef = 1600;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            UpdButton3.SetActive(false);
            FinalButton.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
        }
        if (scoreInt < 400)
        {
         
            print("Недостаточно средств");
        }
    }
}
