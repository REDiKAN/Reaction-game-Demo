using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speedRotate;

    [Header("Setting Speed Rotate")]
    [SerializeField] private bool isIncreaseSpeed;
    [SerializeField] private float coefficientSpeedChange;
    [Header("Limits Speed Rotate")]
    [SerializeField] private float maxSpeedRotateRight;
    [SerializeField] private float maxSpeedRotateLeft;

    private void FixedUpdate()
    {
        RotatePlayer();
        SpeedChanges();
    }

    private void SpeedChanges()
    {

        if (isIncreaseSpeed)
        {
            if (speedRotate < maxSpeedRotateRight)
            {
                speedRotate += coefficientSpeedChange * Time.deltaTime;
            }
        }
        else
        {
            if (speedRotate > maxSpeedRotateLeft)
            {
                speedRotate -= coefficientSpeedChange * Time.deltaTime;
            }
        }
    }

    private void RotatePlayer()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, speedRotate));
    }
}
