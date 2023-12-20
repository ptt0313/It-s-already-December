using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject _victory;
    public GameObject _defeat;
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
        Debug.Log("체력 감소");
        UpdateLifeText();

        if (Life <= 0)
        {
            // 라이프가 0 이하가 되었을 때 게임오버 호출
            GameOver();
        }
    }

    private void GameOver()
    {
        _defeat.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log("Game Over");
        
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
