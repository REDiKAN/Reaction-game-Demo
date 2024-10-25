using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speedRotate;

    [Header("Setting Speed Rotate")]
    [SerializeField] private TypeMove typeMove;

    private void FixedUpdate()
    {
        RotatePlayer();
        SpeedChanges();
    }

    private void SpeedChanges()
    {
        if (typeMove == TypeMove.Left)
        {
            speedRotate = 2f;
        }
        else
        {
            speedRotate = -2f;
        }
    }

    private void RotatePlayer()
    {
        gameObject.transform.Rotate(new Vector3(0, 0, speedRotate));
    }

    public void ChangeDirection()
    {
        if (typeMove == TypeMove.Right)
            typeMove = TypeMove.Left;
        else
            typeMove = TypeMove.Right;
    }
}
public enum TypeMove
{
    Right, Left
}
