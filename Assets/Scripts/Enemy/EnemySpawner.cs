using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [HideInInspector] private List<GameObject> enemyObjects;

    [SerializeField] private List<GameObject> prefabsEnemy;
    [SerializeField] private MoneyManager moneyManager;
    [SerializeField] private PlayerMovement playerMovement;

    [SerializeField] private bool _ischangeDirection;

    private void Update()
    {
        if (enemyObjects.Count > 0)
        {
            for (int i = 0; i < enemyObjects.Count; i++)
            {
                enemyObjects[i].GetComponent<EnemyPerent>().RotateMove(0.3f);
            }
        }
    }

    public void SpawnNewEnemy()
    {
        int _index = Random.Range(0, prefabsEnemy.Count);

        GameObject _enemyObj = Instantiate(prefabsEnemy[_index], gameObject.transform);
        enemyObjects.Add(_enemyObj);

        _enemyObj.transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)));
    }

    public void DestroyEnemy(GameObject _obj, int _money)
    {
        if (_ischangeDirection) { playerMovement.ChangeDirection(); }
        moneyManager.AddMoney(_money);
        enemyObjects.Remove(_obj);
        Destroy(_obj);
    }
}
