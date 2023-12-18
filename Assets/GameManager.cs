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
        Debug.Log("ü�°���");
        if (Life <= 0)
        {

            //�������� 0���ϰ� ������ ���ӿ����� �θ���
            GameOver();
        }
    }
    private void GameOver()
    {
        // ���� ���� ���� ó��
        // �����˾� OR ���ӿ����� �ҷ�����
        Debug.Log("Game Over");
    }
}
