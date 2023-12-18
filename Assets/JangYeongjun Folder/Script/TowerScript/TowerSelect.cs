using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelect : MonoBehaviour
{
    public GameObject Tower1;
    public GameObject Tower2;
    public GameObject Tower3;
    public int towerNumber;
    int TowerNumber { get { return towerNumber; } set { towerNumber = value; } }

    public void SelectTower(Transform tilePosition)
    {
        if (TowerNumber == 0){}
        else if (TowerNumber == 1) 
        { 
            GameObject clone = Instantiate(Tower1, tilePosition.position, Quaternion.identity);
        }
        else if (TowerNumber == 2)
        {
            GameObject clone = Instantiate(Tower2, tilePosition.position, Quaternion.identity);
        }
        else if (TowerNumber == 3)
        {
            GameObject clone = Instantiate(Tower3, tilePosition.position, Quaternion.identity);
        }
    }
}
