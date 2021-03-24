using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class garageFront : MonoBehaviour

{
    public Text motorhp;
    private int HPfront;
    private int updateHPfront1;
    private int scoreInt, rubinInt;
    public GameObject UpdButton1;
    public GameObject UpdButton2;
    public GameObject FinalButton;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("updateHPfront1"))
        {
            PlayerPrefs.SetInt("updateHPfront1", 0);
        }
        if (!PlayerPrefs.HasKey("score"))
        {
            PlayerPrefs.SetInt("score", 0);
        }
        rubinInt = PlayerPrefs.GetInt("rubin");
        HPfront = PlayerPrefs.GetInt("HPfront");
        updateHPfront1 = PlayerPrefs.GetInt("updateHPfront1");
        scoreInt = PlayerPrefs.GetInt("score");
        //updateHPfront1 = 0;
        if (updateHPfront1 == 0)
        {
            HPfront = 1100;
            UpdButton1.SetActive(true);
            motorhp.text = ("Мотор: 2.0 л, 110 л.с.");
        }
        if (updateHPfront1 == 1)
        {
            HPfront = 1280;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            motorhp.text = ("Мотор: 2.5 л, 129 л.с.");
        }
        if (updateHPfront1 == 2)
        {
            HPfront = 1400;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 3.0 л, 140 л.с.");
        }
        if (updateHPfront1 == 3)
        {
            HPfront = 1650;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            FinalButton.SetActive(true);
            motorhp.text = ("Мотор: 3.5 л, 165 л.с.");
        }
    }
    private void Update()
    {
        PlayerPrefs.SetInt("HPfront", HPfront);
        HPfront = PlayerPrefs.GetInt("HPfront");
        PlayerPrefs.SetInt("updateHPfront1", updateHPfront1);
        updateHPfront1 = PlayerPrefs.GetInt("updateHPfront1");
        PlayerPrefs.SetInt("score", scoreInt);
        scoreInt = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
    public void toMaps()
    {
        SceneManager.LoadScene(12);
    }
    public void backToClass()
    {
        SceneManager.LoadScene(10);
    }
    public void UpdateMotor1()
    {
        if (scoreInt >= 200)
        {
            scoreInt = scoreInt - 200;
            motorhp.text = ("Мотор: 2.5 л, 129 л.с.");
            updateHPfront1 = 1;
            HPfront = 1290;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.1");
        }
        if (scoreInt < 200)
        {
            print("Недостаточно средств");
        }
    }
    public void UpdateMotor2()
    {
        if (scoreInt >= 300)
        {
            scoreInt = scoreInt - 300;
            motorhp.text = ("Мотор: 3.0 л, 150 л.с.");
            updateHPfront1 = 2;
            HPfront = 1500;
            UpdButton1.SetActive(false);
            UpdButton2.SetActive(false);
            FinalButton.SetActive(true);
            PlayerPrefs.Save();
            print("Успешная прокачка двигателя ур.2");
        }
        if (scoreInt < 200)
        {
        
            print("Недостаточно средств");
        }
    }
}