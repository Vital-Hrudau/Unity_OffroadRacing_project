using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapsPriora : MonoBehaviour {

    public void LugaLoad()
    {
        SceneManager.LoadScene(19);
    }
    public void LoadRally()
    {
        SceneManager.LoadScene(30);
    }
    public void back()
    {
        SceneManager.LoadScene(20);
    }
}
