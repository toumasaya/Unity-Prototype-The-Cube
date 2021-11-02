using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    Scene _activeScene;

    void Awake () {
        instance = this;
    }

    void Start () {
        _activeScene = SceneManager.GetActiveScene();
    }

    public void StartGame () {
        SceneManager.LoadScene(1);
    }

    public void ExitGame () {
        // Application.Quit();
        SceneManager.LoadScene(0);
    }

    public void LoadCurrentScene () {
        SceneManager.LoadScene(_activeScene.buildIndex);
    }

    public void LoadNextScene () {
        SceneManager.LoadScene(_activeScene.buildIndex + 1);
    }

    IEnumerator RestartCurrentLevel () {
        yield return new WaitForSeconds(1);
        LoadCurrentScene();
    }

    IEnumerator GoNextLevel () {
        yield return new WaitForSeconds(1);
        LoadNextScene();
    }
}
