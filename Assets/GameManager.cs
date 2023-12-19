using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject _victory;
    public Text life;
    [SerializeField] private int Life = 3;
    private void Start()
    {
        UpdateLifeText();
    }
    private void UpdateLifeText()
    {
        life.text = Life.ToString();
    }
    public void DecreaseLife(int amount)
    {
        Life -= amount;
        Debug.Log("체력감소");
        UpdateLifeText();
        if (Life <= 0)
        {
            //라이프가 0이하가 됬을시 게임오버 부르기
            GameOver();
        }
    }
    private void GameOver()
    {
        // 종료팝업 불러오기
        Debug.Log("Game Over");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Debug.Log("충돌");
            Destroy(collision.gameObject);
            DecreaseLife(1);
        }
    }
    private void OnDestroy()
    {
        // 파괴된 게임 오브젝트의 레이어가 Boss일 때 _victory를 활성화
        if (gameObject.layer == LayerMask.NameToLayer("Boss"))
        {
            Invoke("GameVictory", 3f);
        }
    }
    private void GameVictory()
    {
        
        _victory.SetActive(true);
    }
}
