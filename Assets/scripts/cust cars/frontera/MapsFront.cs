using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapsFront : MonoBehaviour {


    public void LugaLoad()
    {
        SceneManager.LoadScene(13);
    }
    public void RallyLoad()
    {
        SceneManager.LoadScene(28);
    }
    public void back()
    {
        SceneManager.LoadScene(11);
    }
}
