using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsControll : MonoBehaviour
{
    public PointsVariable _points;
    [SerializeField] Text _pointsText;

    void Start()
    {
        _pointsText = GetComponent<Text>();
        _pointsText.text = (_points.value).ToString();
    }

    void Update()
    {
        _pointsText.text = (_points.value).ToString();
    }
}
