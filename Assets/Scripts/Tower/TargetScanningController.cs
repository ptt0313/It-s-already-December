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

    public List<GameObject> Targets { get { return targets; } }

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
        

        if (!targets.Contains(collision.gameObject) && ((1 << collision.gameObject.layer) & enemyCollisionLayer.value) != 0) // 나중에 태그 검사 할 때 레이어 검사를 공통으로 묶어서 메소드로 빼면 우선순위 검사 추가가 쉬울듯
        {
            targets.Add(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (targets.Count >= scanCount) return;

        // 더 높은 인식 로직이 필요할 수도 (남은 체력량이나 거리 계산등)
        // 재탐색 하는 경우에는 physics를 이용하는 방법도 생각해보자
        if (targets.Count < scanCount)
        {
            if (!targets.Contains(collision.gameObject) && ((1 << collision.gameObject.layer) & enemyCollisionLayer.value) != 0)
            {
                targets.Add(collision.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (targets.Count == 0) return;

        if (targets.Contains(collision.gameObject) && ((1 << collision.gameObject.layer) & enemyCollisionLayer.value) != 0)
        {
            targets.Remove(collision.gameObject);
        }
    }
}
