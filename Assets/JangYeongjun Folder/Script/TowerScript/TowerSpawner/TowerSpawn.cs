using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawn : MonoBehaviour
{
    public GameObject[] towers = new GameObject[3];
    public ChangeTowerImage changeTowerImage = new ChangeTowerImage();

    public void OnSpawnTower(int towerNumber, Transform tilePosition)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Tiles tile = tilePosition.GetComponent<Tiles>();
        if (tile.IsBuild >= 3 || towerNumber <= 0 || towerNumber > towers.Length)
        {
            return;
        }

        GameObject selectedTower = towers[towerNumber - 1];
        if (selectedTower != null || tile.IsBuild == 0)
        {
            if (DataManager.instance.player.Coin >= 200)
            {
                tile.IsBuild++;
                Instantiate(selectedTower, tilePosition.position, Quaternion.identity);
                DataManager.instance.LoadPlayerData();
                DataManager.instance.player.Coin -= 200;
                DataManager.instance.SavePlayerData();
            }
        }
        else if (selectedTower != null || tile.IsBuild == 1)
        {
            tile.IsBuild++;
            changeTowerImage.TowerSpriteChange(changeTowerImage.TowerLv2);
            DataManager.instance.LoadPlayerData();
            DataManager.instance.player.Coin -= 400;
            DataManager.instance.SavePlayerData();
        }
        else if (selectedTower != null || tile.IsBuild == 2)
        {
            tile.IsBuild++;
            changeTowerImage.TowerSpriteChange(changeTowerImage.TowerLv3);
            DataManager.instance.LoadPlayerData();
            DataManager.instance.player.Coin -= 600;
            DataManager.instance.SavePlayerData();
        }
    }
}
