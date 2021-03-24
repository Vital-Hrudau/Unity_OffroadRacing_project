using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapsDef : MonoBehaviour {

    public void LugaLoad()
    {
        SceneManager.LoadScene(14);
    }
    public void rallyLoad()
    {
        SceneManager.LoadScene(29);
    }
    public void back()
    {
        SceneManager.LoadScene(16);
    }
}
