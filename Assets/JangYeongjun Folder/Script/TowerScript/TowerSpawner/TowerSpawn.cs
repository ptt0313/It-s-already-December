using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public GameObject[] towers = new GameObject[3];

    public void SpawnTower(int towerNumber, Transform tilePosition)
    {
        Debug.Log("타워설치");
        Tiles tile = tilePosition.GetComponent<Tiles>();

        if (tile.IsBuild == true || towerNumber <= 0 || towerNumber > towers.Length)
        {
            return;
        }

        GameObject selectedTower = towers[towerNumber - 1];
        TowerInfoHandler towerInfoHandler = selectedTower.GetComponent<TowerInfoHandler>();
        if (selectedTower != null && tile.IsBuild == false && DataManager.instance.player.Coin >= towerInfoHandler.TowerInfo.towerCost)
        {
            tile.IsBuild = true;
            Instantiate(selectedTower, tilePosition.position, Quaternion.identity);
            MonyControll(towerInfoHandler.TowerInfo.towerCost);
        }
    }
    private void MonyControll(int coin)
    {
        DataManager.instance.LoadPlayerData();
        DataManager.instance.player.Coin -= coin;
        DataManager.instance.SavePlayerData();
    }
}
