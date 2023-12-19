using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TowerInfoData", menuName = "TowerData/InfoData")]

public class TowerInfoData : ScriptableObject
{
    [Header("TowerInfo")]
    public string towerName;
    public int towerCost;
    public Sprite towerImage;

    [Header("TowerScanInfo")]
    public float scannigRange;
    public LayerMask targetLayer;
    public int targetCount;

    [Header("TowerAttackInfo")]
    [Tooltip("TowerAttackBaseData를 상속 받은 공격 파일을 여기에 연결하면 됩니다.")]
    public TowerAttackBaseData towerAttackData;
}
