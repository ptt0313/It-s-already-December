using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultEnemyInfo", menuName = "Enemy/Attack", order = 0)]
public class EnemyObjectable : ScriptableObject
{
    [Header("Attack Info")]

    public int speed;
    public int maxHp;

}
