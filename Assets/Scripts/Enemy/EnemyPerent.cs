using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPerent : MonoBehaviour
{
    public void RotateMove(float _speed) => gameObject.transform.Rotate(new Vector3(0, 0, _speed));
}
