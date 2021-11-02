using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public PointsVariable _currentPoints;
    public PointsVariable _totalPoints;

    void Start() {
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            Points.instance.AddPoint();
            Destroy(this.gameObject);
        }
    }
}
