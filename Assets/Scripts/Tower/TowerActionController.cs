using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerActionController : MonoBehaviour
{
    private MonoBehaviour _ActionController;
    private TowerInfoHandler _infoHandler;

    private void Awake()
    {
        _infoHandler = GetComponent<TowerInfoHandler>();
    }

    private void Start()
    {
        switch (_infoHandler.TowerInfo.towerAttackData.attackType)
        {
            case AttackType.RangeAttack :
                _ActionController = gameObject.AddComponent<TowerRangeAttackController>();
                break;
        }
    }
}
