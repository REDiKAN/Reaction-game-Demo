using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerUse : MonoBehaviour
{
    [Inject] private EnemySpawner enemySpawner;

    [SerializeField] public List<Enemy> selectEnemyList;

    private void OnTriggerEnter2D(Collider2D collision) => selectEnemyList.Add(collision.gameObject.GetComponent<Enemy>());

    private void OnTriggerExit2D(Collider2D collision) => selectEnemyList.Remove(collision.gameObject.GetComponent<Enemy>());

    public void RemovalSelectionEnemy()
    {
        for (int i = 0; i < selectEnemyList.Count; i++)
            selectEnemyList[i].OnDestroyObject(enemySpawner);

        selectEnemyList.Clear();
    }
}
