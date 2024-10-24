using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Buttons Setting")]
    [SerializeField] private KeyCode mainButtons;

    [SerializeField] private PlayerUse playerUse;

    private void Update()
    {
        ClickTracking();
    }

    private void ClickTracking()
    {
        if (Input.GetKeyDown(mainButtons))
        {
            OnClick();
        }
    }

    private void OnClick()
    {
        if (playerUse.selectEnemyList.Count > 0) { playerUse.RemovalSelectionEnemy(); }
    }

}
