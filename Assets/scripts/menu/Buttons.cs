using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public int scoreInt, rubinInt;
    public GameObject store;

    private void Start()
    {
        store.SetActive(false);
        scoreInt = PlayerPrefs.GetInt("score");
        rubinInt = PlayerPrefs.GetInt("rubin");
    }
    private void Update()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        PlayerPrefs.SetInt("rubin", rubinInt);
    }
    public void garageclick()
    {
        SceneManager.LoadScene(1);
    }	
    public void googleplay()
    {
        Application.OpenURL("https://play.google.com/store/apps/developer?id=VitGames");
    }
    public void gmail()
    {
        Application.OpenURL("https://mailto:vitogrudov@gmail.com");
    }
    public void Store()
    {
        store.SetActive(true);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void exitStore()
    {
        store.SetActive(false);
    }



}
