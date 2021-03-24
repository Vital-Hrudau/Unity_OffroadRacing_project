using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapsAscona : MonoBehaviour {


    public void LugaLoad()
    {
        SceneManager.LoadScene(22);
    }
    public void LoadRally()
    {
        SceneManager.LoadScene(31);
    }
    public void back()
    {
        SceneManager.LoadScene(24);
    }
}
