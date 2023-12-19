using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RangeAttackData", menuName = "TowerData/AttackInfo/Range")]

public class TowerRangeAttackData : TowerAttackBaseData
{
    [Header("bullet Info")]
    public float bulletSpeed;
    public float splashArea;
}
