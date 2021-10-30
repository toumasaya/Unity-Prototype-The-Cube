using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public PointsVariable _points;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            _points.value += 1;
            Destroy(this.gameObject);
        }
    }
}
