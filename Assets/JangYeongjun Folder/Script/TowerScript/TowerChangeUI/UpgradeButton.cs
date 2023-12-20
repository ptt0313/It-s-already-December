using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public GameObject upgradeObject;

    public void OnButton()
    {
        if (upgradeObject != null)
        {
            // 현재 상태의 반전
            upgradeObject.SetActive(!upgradeObject.activeSelf);
        }
    }
}
