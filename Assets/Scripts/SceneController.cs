using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void StartGame () {
        SceneManager.LoadScene(1);
    }

    public void ExitGame () {
        // Application.Quit();
        SceneManager.LoadScene(0);
    }
}
