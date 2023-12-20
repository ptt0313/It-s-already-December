using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerChanger : MonoBehaviour
{
    public delegate void DepositAction(int towerNumber);
    public static event DepositAction onClick;


    public enum TowerType
    {
        None,
        Tower1,
        Tower2,
        Tower3
    }
   
    private static readonly Dictionary<TowerType, int> TowerNumber = new Dictionary<TowerType, int>
    {
        {TowerType.None, 0},
        {TowerType.Tower1, 1},
        {TowerType.Tower2, 2},
        {TowerType.Tower3, 3},

    };
    public TowerType towerType;
    public void SendValue()
    {
        int towerNumber = TowerNumber.TryGetValue(towerType, out int value) ? value : 0;
        onClick?.Invoke(towerNumber);
    }
}
