using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControll : MonoBehaviour
{
    Scene _scene;
    public PointsVariable _points;

    void Start()
    {
        _scene = SceneManager.GetActiveScene();
    }

    void Update() {

    }

    public void StartGame () {
        // Reset points
        _points.value = 0;
        SceneManager.LoadScene(1);
    }

    public void ExitGame () {
        // Application.Quit();
        SceneManager.LoadScene(0);
    }
}
