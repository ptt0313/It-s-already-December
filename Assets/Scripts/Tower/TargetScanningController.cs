using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TargetScanningController : MonoBehaviour
{
    private TowerInfoHandler _towerInfo;
    private CircleCollider2D _circleCollider;
    private LayerMask enemyCollisionLayer;

    [SerializeField] private List<GameObject> targets = new List<GameObject>();
    private float scanRange;
    private int scanCount;

    private void Awake()
    {
        _towerInfo = GetComponent<TowerInfoHandler>();
        _circleCollider = GetComponent<CircleCollider2D>();
    }

    private void Start()
    {
        enemyCollisionLayer = _towerInfo.TowerInfo.targetLayer;
        scanRange = _towerInfo.TowerInfo.scannigRange;
        scanCount = _towerInfo.TowerInfo.targetCount;

        _circleCollider.radius = scanRange;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (targets.Count >= scanCount) return;

        if (!targets.Contains(collision.gameObject) && (1 << collision.gameObject.layer) == enemyCollisionLayer.value)
        {
            targets.Add(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (targets.Count < scanCount)
        {
            if (!targets.Contains(collision.gameObject) && (1 << collision.gameObject.layer) == enemyCollisionLayer.value)
            {
                targets.Add(collision.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (targets.Count == 0) return;

        if (targets.Contains(collision.gameObject) && (1 << collision.gameObject.layer) == enemyCollisionLayer.value)
        {
            targets.Remove(collision.gameObject);
        }
    }
}
