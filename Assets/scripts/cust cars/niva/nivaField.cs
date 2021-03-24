using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nivaField : MonoBehaviour {

    public float timer;
    private void Start()
    {
        timer = PlayerPrefs.GetFloat("timer");
    }
    private void Update()
    {
        PlayerPrefs.SetFloat("timer", timer);
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            timer = 0;
        }
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void toUaz()
    {
        SceneManager.LoadScene(3);
    }
    public void toGarage()
    {
        SceneManager.LoadScene(4);
    }

}
