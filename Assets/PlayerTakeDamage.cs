using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] private LayerMask collisionLayer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("충돌");

        if (collisionLayer.value == (collisionLayer | 1 << (collision.gameObject.layer)))
        {
            Debug.Log("적확인");
            Destroy(collision.gameObject);
            gameManager.DecreaseLife(1);
        }
    }
}
