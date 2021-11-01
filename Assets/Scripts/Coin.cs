using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public PointsVariable _currentPoints;
    public PointsVariable _totalPoints;
    PointsControll f_PointsControll;

    void Start() {
        f_PointsControll = GameObject.FindGameObjectWithTag("GameController").GetComponent<PointsControll>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            // _currentPoints.value += 1;
            // _totalPoints.value += _currentPoints.value;
            f_PointsControll.AddPoints();
            Destroy(this.gameObject);
        }
    }
}
