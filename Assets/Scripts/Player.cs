using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        // Handle player gravity
        float _getVelocityY = _rigidBody.velocity.y;
        // Input horizontal control
        float _controlHorizontalPos = Input.GetAxis("Horizontal") * _horizontalSpeed;
        // Get Position Y
        float _getPositionY = transform.position.y;
        // Using Rigidbody.velocity make player move x position, go forward, and keep right gravity
        _rigidBody.velocity = new Vector3(_controlHorizontalPos, _getVelocityY, _forwardSpeed);

        // If falling, restart the current scene
        if (_getPositionY < -1) {
            SceneController.instance.StartCoroutine("RestartCurrentLevel");
        }


    }


    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Enemy")) {
            // If colliding enemy, restart current scene
            SceneController.instance.StartCoroutine("RestartCurrentLevel");
        } else if (other.gameObject.CompareTag("Finish")) {
            // If trigger finish, go to next level, and stopping player physics
            _rigidBody.isKinematic = true;
            Points.instance.CalculateTotalPoints();
            SceneController.instance.StartCoroutine("GoNextLevel");
        }
    }
}
