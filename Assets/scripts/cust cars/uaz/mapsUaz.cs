using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapsUaz : MonoBehaviour {

    public void LugaLoad()
    {
        SceneManager.LoadScene(9);
    }
    public void RallyLoad()
    {
        SceneManager.LoadScene(27);
    }
    public void back()
    {
        SceneManager.LoadScene(7);
    }
}
