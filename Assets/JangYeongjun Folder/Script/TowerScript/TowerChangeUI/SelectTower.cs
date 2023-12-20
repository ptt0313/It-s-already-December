using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTower : MonoBehaviour
{
    private ChangeTowerImage changeTowerImage;
    private Camera cameraMain;
    private Ray ray;
    private RaycastHit2D hit;
    public int upgradeNumber = 0;
    Sprite nowSprite;

    private void Awake()
    {
        cameraMain = Camera.main;
        changeTowerImage = GetComponent<ChangeTowerImage>();
    }
    private void Start()
    {
        nowSprite = changeTowerImage.TowerLv1;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpgradeSprite();
        }
    }
    private void DeductMoney(int coin)
    {
        DataManager.instance.LoadPlayerData();
        DataManager.instance.player.Coin -= coin;
        DataManager.instance.SavePlayerData();
    }
    private void UpgradeSprite()
    {
        ray = cameraMain.ScreenPointToRay(Input.mousePosition);

        hit = Physics2D.Raycast(ray.origin, ray.direction);

        SpriteRenderer spriteRenderer = hit.collider.GetComponent<SpriteRenderer>();

        if (hit.collider != null && hit.collider.CompareTag("Tower") && spriteRenderer != null)
        {
            if (nowSprite == changeTowerImage.TowerLv1)
            {
                changeTowerImage.TowerSpriteChange(spriteRenderer, changeTowerImage.TowerLv2);
                DeductMoney(400);
            }
            else if (nowSprite == changeTowerImage.TowerLv2)
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
}
