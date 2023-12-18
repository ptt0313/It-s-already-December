using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelect : MonoBehaviour
{
    public GameObject Tower1;
    public GameObject Tower2;
    public GameObject Tower3;
    public GameObject Tower4;
    public GameObject Tower5;
    int towerNumber = 0;

    public void SelectTower(Transform tilePosition)
    {
        if (towerNumber == 0){}
        else if (towerNumber == 1) 
        { 
            GameObject clone = Instantiate(Tower1, tilePosition.position, Quaternion.identity);
        }
        else if (towerNumber == 2)
        {
            GameObject clone = Instantiate(Tower2, tilePosition.position, Quaternion.identity);
        }
        else if (towerNumber == 3)
        {
            GameObject clone = Instantiate(Tower3, tilePosition.position, Quaternion.identity);
        }
        else if (towerNumber == 4)
        {
            GameObject clone = Instantiate(Tower4, tilePosition.position, Quaternion.identity);
        }
        else if (towerNumber == 5)
        {
            GameObject clone = Instantiate(Tower5, tilePosition.position, Quaternion.identity);
        }
    }
}
