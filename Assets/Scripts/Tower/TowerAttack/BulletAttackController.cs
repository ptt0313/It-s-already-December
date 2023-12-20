using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletAttackController : MonoBehaviour
{
    private GameObject _attackTarget;
    private TowerRangeAttackData _attackData;

    private Rigidbody2D _rigidbody2D;
    private Vector2 _velocity;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        ApplyTargetMove();
    }

    public void InitBulletAttackData(GameObject target, TowerAttackBaseData attackData)
    {
        _attackTarget = target;
        if (attackData is TowerRangeAttackData)
        {
            _attackData = attackData as TowerRangeAttackData;
        }
    }

    private void ApplyTargetMove()
    {
        Vector2 direction = (_attackTarget.transform.position - transform.position).normalized;
        _rigidbody2D.velocity = direction * _attackData.bulletSpeed;
    }
}
