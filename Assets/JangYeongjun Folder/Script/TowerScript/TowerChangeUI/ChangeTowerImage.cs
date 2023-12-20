using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTowerImage : MonoBehaviour
{
    public Sprite TowerLv1, TowerLv2, TowerLv3;
    void Start()
    {
        TowerSpriteChange(TowerLv1);
    }
    public void TowerSpriteChange(Sprite sprite)
    {
        // SpriteRenderer 컴포넌트 가져오기
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // 스프라이트 변경
        if (spriteRenderer != null && sprite != null)
        {
            spriteRenderer.sprite = sprite;
        }
        else
        {
            Debug.LogWarning("SpriteRenderer or Sprite is null.");
        }
    }
}
