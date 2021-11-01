using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsControll : MonoBehaviour
{
    public PointsVariable _totalPoints;
    public PointsVariable _currentPoints;
    [SerializeField] Text _totalPointsText;

    void Start()
    {
        if (_totalPointsText != null) {
            _totalPointsText = GetComponent<Text>();
            _totalPointsText.text = (_totalPoints.value).ToString();
        }

    }

    void FixedUpdate()
    {
        // _currentPointsText.text = (_currentPoints.value).ToString();
        // _totalPointsText.text = (_totalPoints.value).ToString();
        AddPoints();
    }

    public void AddPoints () {
        _currentPoints.value += 1;
        _totalPoints.value = _currentPoints.value;
        if (_totalPointsText != null) {
            _totalPointsText.text = (_totalPoints.value).ToString();
        }
    }

    public void ResetPoints () {
        _currentPoints.value = 0;
        _totalPoints.value = 0;
        if (_totalPointsText != null) {
            _totalPointsText.text = (_totalPoints.value).ToString();
        }
    }

    public void Hello () {
        Debug.Log("Hello");
    }
}
