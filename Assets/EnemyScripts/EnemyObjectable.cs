using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultEnemyInfo", menuName = "Enemy/ Enemy Info", order = 0)]  
public class EnemyObjectable : ScriptableObject
{
    [Header("Enemy Info")]

    public int speed;
    public int maxHp;

}
