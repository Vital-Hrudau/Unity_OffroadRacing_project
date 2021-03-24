using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maps2107 : MonoBehaviour {

    public void LugaLoad()
    {
        SceneManager.LoadScene(40);
    }
    public void LoadRally()
    {
        SceneManager.LoadScene(41);
    }
    public void back()
    {
        SceneManager.LoadScene(38);
    }
}
