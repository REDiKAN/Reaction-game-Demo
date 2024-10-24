using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int moneyCount;

    [SerializeField] private GameObject perentObj;

    public void OnDestroyObject(EnemySpawner _enemySpawner)
    {
        _enemySpawner.SpawnNewEnemy();
        _enemySpawner.DestroyEnemy(perentObj, moneyCount);
    }
}
