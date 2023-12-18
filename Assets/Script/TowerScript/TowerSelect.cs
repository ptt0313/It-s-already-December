using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelect : MonoBehaviour
{
    public GameObject Tower;

    public void SelectTower(Transform tilePosition)
    {
        GameObject clone = Instantiate(Tower, tilePosition.position, Quaternion.identity);
    }
}
