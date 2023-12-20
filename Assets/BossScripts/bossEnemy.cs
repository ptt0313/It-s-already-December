using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossEnemy : MonoBehaviour
{
    private int wayPointCount;
    private Transform[] wayPoints;
    private int currentIndex = 0;
    private BossMovement2D bossmovement2D;

    public void Setup(Transform[] wayPoints)
    {
        bossmovement2D = GetComponent<BossMovement2D>();

        wayPointCount = wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount];
        this.wayPoints = wayPoints;

        transform.position = wayPoints[currentIndex].position;

        StartCoroutine("OnMove");
    }

    private IEnumerator OnMove()
    {
        NextMoveTo();

        while (true)
        {
           
            if (Vector3.Distance(transform.position, wayPoints[currentIndex].position) < 0.02f * bossmovement2D.BossMoveSpeed)
            {
                NextMoveTo();
            }
            yield return null;
        }
    }

    private void NextMoveTo()
    {

        if (currentIndex < wayPointCount - 1)
        {
            transform.position = wayPoints[currentIndex].position;

            currentIndex++;
            Vector3 direction = (wayPoints[currentIndex].position - transform.position).normalized;
            bossmovement2D.MoveTo(direction);
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
