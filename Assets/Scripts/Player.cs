using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField] float _forwardSpeed = 10;
    [SerializeField] float _horizontalSpeed = 10;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float _getVelocityY = _rigidBody.velocity.y;
        float _controlHorizontalPos = Input.GetAxis("Horizontal") * _horizontalSpeed;

        _rigidBody.velocity = new Vector3(_controlHorizontalPos, _getVelocityY, _forwardSpeed);
    }
}
