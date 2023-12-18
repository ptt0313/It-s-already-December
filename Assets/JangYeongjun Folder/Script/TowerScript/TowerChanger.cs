using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerChanger : MonoBehaviour
{
    TowerSelect towerSelect;
    private void Start()
    {
        towerSelect = GetComponent<TowerSelect>();
    }
    private void FristTower()
    {
        towerSelect.towerNumber = 1;
    }
    private void SecondTower()
    {
        towerSelect.towerNumber = 1;
    }
    private void ThirdTower()
    {
        towerSelect.towerNumber = 1;
    }
}
