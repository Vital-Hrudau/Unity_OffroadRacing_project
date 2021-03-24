using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapsNiva : MonoBehaviour {

    public void LugaLoad()
    {
        SceneManager.LoadScene(6);
    }
    public void map2()
    {
        SceneManager.LoadScene(26);
    }
    public void back()
    {
        SceneManager.LoadScene(4);
    }
}
