using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;
    public PointsVariable _currentPoints;
    public PointsVariable _totalPoints;
    public Text _currentPointsText;
    public Text _totalPointsText;

    void Awake () {
        instance = this;
    }

    void Start()
    {
        if (_currentPointsText != null)
            ResetCurrentPoints();
        else
            Debug.Log("===== Error ===== Missing: Current Points Text");

        if (_totalPointsText != null)
            CalculateTotalPoints ();
        else
            Debug.Log("===== Error ===== Missing: Total Points Text");

    }

    void Update()
    {
        _currentPointsText.text = (_currentPoints.value).ToString();
    }

    public void ResetCurrentPoints () {
        _currentPoints.value = 0;
        _currentPointsText.text = (_currentPoints.value).ToString();
    }

    public void AddPoint () {
        _currentPoints.value += 1;
    }

    public void CalculateTotalPoints () {
        _totalPoints.value += _currentPoints.value;
        _totalPointsText.text = (_totalPoints.value).ToString();
    }
}
