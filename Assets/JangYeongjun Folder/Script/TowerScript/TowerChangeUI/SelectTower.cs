using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTower : MonoBehaviour
{
    private ChangeTowerImage changeTowerImage;
    private Camera cameraMain;
    public int upgradeNumber = 0;
    public Sprite nowSprite;

    private void Awake()
    {
        cameraMain = Camera.main;
        changeTowerImage = GetComponent<ChangeTowerImage>();
    }
    private void Start()
    {
        nowSprite = changeTowerImage.TowerLv1;
    }
    private void DeductMoney(int coin)
    {
        DataManager.instance.LoadPlayerData();
        DataManager.instance.player.Coin -= coin;
        DataManager.instance.SavePlayerData();
    }
    public void UpgradeSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (nowSprite == changeTowerImage.TowerLv1 && DataManager.instance.player.Coin >= 400)
        {
            changeTowerImage.TowerSpriteChange(spriteRenderer, changeTowerImage.TowerLv2);
            DeductMoney(400);
        }
        else if (nowSprite == changeTowerImage.TowerLv2 && DataManager.instance.player.Coin >= 600)
        {
            changeTowerImage.TowerSpriteChange(spriteRenderer, changeTowerImage.TowerLv3);
            DeductMoney(600);
        }
        else
        {
            return;
        }
    }
}
