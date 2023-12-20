using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletAttackController : MonoBehaviour
{
    private GameObject _attackTarget;
    private TowerRangeAttackData _attackData;

    private Rigidbody2D _rigidbody2D;
    private CircleCollider2D _circleCollider2D;
    private Vector2 _velocity;
    private LayerMask _enemyLayer;

    private Vector3 _targetPosition;

    private float _positionDistanceCheck = 0.1f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _circleCollider2D = GetComponent<CircleCollider2D>();
        _enemyLayer = LayerMask.NameToLayer("Enemy");
    }

    private void Start()
    {
        _circleCollider2D.radius = _attackData.bulletEnterSize;
    }

    private void Update()
    {
        ApplyTargetPosition();
        ApplyMove();
        NullTargetPositionEnter();
    }

    public void InitBulletAttackData(GameObject target, TowerAttackBaseData attackData)
    {
        _attackTarget = target;
        if (attackData is TowerRangeAttackData)
        {
            _attackData = attackData as TowerRangeAttackData;
        }
    }
    private void ApplyTargetPosition()
    {
        if ( _attackTarget == null )
        {
            return;
        }
        else
        {
            _targetPosition = _attackTarget.transform.position;
        }
    }

    private void NullTargetPositionEnter()
    {
        if ( _attackTarget == null && Vector3.Distance(_targetPosition, transform.position) < _positionDistanceCheck)
        {
            DestroyBulletObject();
        }
    }

    private void ApplyMove()
    {
        Vector2 direction = (_targetPosition - transform.position).normalized;
        _rigidbody2D.velocity = direction * _attackData.bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == _attackTarget.gameObject) // && ((1 << collision.gameObject.layer) & _enemyLayer.value) != 0)
        {
            // 여기에 체력 감소 로직 추가 필요
            Hpbar hpbar = collision.GetComponent<Hpbar>();
            hpbar.TakeDamage((int)_attackData.damage);
            DestroyBulletObject();
        }
    }

    private void DestroyBulletObject()
    {
        ProjectileManager.instance.RemoveBulletObject(gameObject);
    }
}
