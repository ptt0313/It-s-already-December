using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    SelectTile selectTile;

    private void Start()
    {
        selectTile = GetComponent<SelectTile>();
    }
    private void OnEnable()
    {
        TowerChanger.onClick += HandleClick;
    }

    private void OnDisable()
    {
        TowerChanger.onClick -= HandleClick;
    }

    private void HandleClick(int buttonValue)
    {
        selectTile.towerNumber = buttonValue;
    }
}
