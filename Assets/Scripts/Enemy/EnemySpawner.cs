using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> prefabsEnemy;

    public void SpawnNewEnemy()
    {
        int _index = Random.Range(0, prefabsEnemy.Count);

        GameObject _enemyObj = Instantiate(prefabsEnemy[_index], gameObject.transform);

        _enemyObj.transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
    }

    public void DestroyEnemy(GameObject _obj) => Destroy(_obj);
}
