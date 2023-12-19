using System;
using UnityEngine;

public enum AttackType
{
    MeleeAttack,
    RangeAttack
}

public class TowerAttackBaseData : ScriptableObject
{
    // 공격 타입이 새로 추가되면 이 클래스를 무조건 상속해줍니다.
    [Header("Attack Info")]
    public AttackType attackType;
    public float damage;
    public float delay;
}