using System;
using UnityEngine;

public enum AttackType
{
    MeleeAttack,
    RangeAttack
}

public class TowerAttackBaseData : ScriptableObject
{
    [Header("Attack Info")]
    public AttackType attackType;
    public float damage;
    public float delay;
}