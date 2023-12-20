using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRangeAttackController : MonoBehaviour
{
    [SerializeField] private Transform _bulletSpawnPosition;

    private TowerInfoHandler _infoHandler;
    private TowerAttackBaseData _rangeAttackData;
    private TargetScanningController _targetData;


    private float _lastAttackDelay = 0f;

    private void Awake()
    {
        _infoHandler = gameObject.GetComponent<TowerInfoHandler>();
        _rangeAttackData = _infoHandler.TowerInfo.towerAttackData;
        _targetData = gameObject.GetComponent<TargetScanningController>();
        _bulletSpawnPosition = transform.Find("MainSprite").Find("AttackPivot");
    }

    private void Update()
    {
        if (_lastAttackDelay > 0f)
        {
            _lastAttackDelay -= Time.deltaTime;
        }

        if (_lastAttackDelay <= 0f && _targetData.Targets.Count > 0)
        {
            for (int i = 0; i < _targetData.Targets.Count; i++)
            {
                GameObject bullet = ProjectileManager.instance.GetBulletObject();
                bullet.transform.position = _bulletSpawnPosition.position;
                BulletAttackController bulletAttackController = bullet.GetComponent<BulletAttackController>();
                bulletAttackController.InitBulletAttackData(_targetData.Targets[i], _rangeAttackData);
            }
            _lastAttackDelay = _rangeAttackData.delay;
        }
    }
}
