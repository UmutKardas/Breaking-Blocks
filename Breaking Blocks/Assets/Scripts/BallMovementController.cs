using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D ballRigidbody2D;
    [SerializeField] private float ballMovementSpeed;


    void Start()
    {
        SetBallMovement();
    }



    private void SetBallMovement()
    {
        ballRigidbody2D.AddForce(Vector3.up * ballMovementSpeed);
    }

}
