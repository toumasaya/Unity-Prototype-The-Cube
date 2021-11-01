using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControll : MonoBehaviour
{
    Scene _scene;
    public PointsVariable _totalPoints;
    public PointsVariable _currentPoints;
    PointsControll f_PointsControll;

    void Start()
    {
        _scene = SceneManager.GetActiveScene();
        f_PointsControll = GameObject.FindGameObjectWithTag("GameController").GetComponent<PointsControll>();
        f_PointsControll.Hello();
    }

    void Update() {

    }

    public void StartGame () {
        // Reset points
        // _totalPoints.value = 0;
        // _currentPoints.value = 0;
        f_PointsControll.ResetPoints();
        SceneManager.LoadScene(1);
    }

    public void ExitGame () {
        // Application.Quit();
        SceneManager.LoadScene(0);
    }
}
