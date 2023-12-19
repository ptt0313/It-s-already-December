using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public GameObject[] towers = new GameObject[3];

    public void SpawnTower(int towerNumber, Transform tilePosition)
    {
        Tiles tile = tilePosition.GetComponent<Tiles>();
        if (tile.IsBuild == true || towerNumber <= 0 || towerNumber > towers.Length)
        {
            return;
        }

        GameObject selectedTower = towers[towerNumber - 1];
        if (selectedTower != null || tile.IsBuild == false)
        {
            tile.IsBuild = true;
            Instantiate(selectedTower, tilePosition.position, Quaternion.identity);
            DataManager.instance.LoadPlayerData();
            DataManager.instance.player.Coin -= 200;
            DataManager.instance.SavePlayerData();
        }
    }
}
