using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControll : MonoBehaviour
{
    Scene _scene;
    // Start is called before the first frame update
    void Start()
    {
        _scene = SceneManager.GetActiveScene();
    }

    public void StartGame () {
        SceneManager.LoadScene(1);
    }

    public void ExitGame () {
        Application.Quit();
    }

}
