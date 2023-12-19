using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int Life = 3;
    public void DecreaseLife(int amount)
    {
        Life -= amount;
        Debug.Log("체력감소");
        if (Life <= 0)
        {

            //라이프가 0이하가 됬을시 게임오버씬 부르기
            GameOver();
        }
    }
    private void GameOver()
    {
        // 게임 오버 시의 처리
        // 종료팝업 OR 게임오버씬 불러오기
        Debug.Log("Game Over");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Destroy(collision.gameObject);
            DecreaseLife(1);
        }
    }
}
