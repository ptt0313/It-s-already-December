using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTowerImage : MonoBehaviour
{
    public Sprite TowerLv1, TowerLv2, TowerLv3;
    SelectTower selectTower;

    public void Start()
    {
        selectTower = GetComponent<SelectTower>();
    }
    public void TowerSpriteChange(SpriteRenderer spriteRenderer, Sprite sprite)
    {
        // 스프라이트 변경
        if (spriteRenderer != null && sprite != null)
        {
            spriteRenderer.sprite = sprite;
            selectTower.nowSprite =  sprite;
        }
    }
}
