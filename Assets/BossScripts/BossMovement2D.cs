using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement2D : MonoBehaviour
{
    [SerializeField]
    private float bossmoveSpeed = 0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.zero;

    public float BossMoveSpeed => bossmoveSpeed;

    private void Update()
    {
        transform.position += moveDirection * bossmoveSpeed * Time.deltaTime;
    }

    public void MoveTo(Vector3 direction)
    {
        moveDirection = direction;
    }
}
