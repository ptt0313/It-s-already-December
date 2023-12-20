using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInfoHandler : MonoBehaviour
{
    [SerializeField] private TowerInfoData towerInfo;
    public TowerInfoData TowerInfo { get { return towerInfo; } }

    private Sprite _towerSprite;

    private void Awake()
    {
        //_towerSprite = GetComponentInChildren<Sprite>();
    }

    private void Start()
    {
        if (_towerSprite != null)
        {
            _towerSprite = towerInfo.towerImage;
        }
    }
}
