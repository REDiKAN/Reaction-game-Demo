using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [Header("Setting Parameters")]
    [SerializeField] private MoneyInterfase moneyInterfase;

    [SerializeField] private int moneyCount;

    public void AddMoney(int _money)
    {
        moneyCount += _money;
        moneyInterfase.Value = moneyCount;
    }
}
