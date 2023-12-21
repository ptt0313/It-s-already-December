using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private bool isDie = false;
   private EnemyStatsHandler enemyStatsHandler;


    private void Awake()
    {
        Enemy enemy = GetComponent<Enemy>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemyStatsHandler = GetComponent<EnemyStatsHandler>();
    }

    public void TakeDamage(int damage)
    {
        if (isDie == true) return;

        enemyStatsHandler.currentHealth -= damage; //타워데미지
        Debug.Log(enemyStatsHandler.currentHealth);

        StopCoroutine("HitAnimation");
        StartCoroutine("HitAnimation");

        if(enemyStatsHandler.currentHealth <= 0)
        {
            isDie = true;
            Destroy(gameObject);
            MonyControll(100);
        }
    }
    private void MonyControll(int coin)
    {
        DataManager.instance.LoadPlayerData();
        DataManager.instance.player.Coin += coin;
        DataManager.instance.SavePlayerData();
    }

    private IEnumerator HitAnimation()
    {
        Color color = spriteRenderer.color;

        color.a = 0.4f;
        spriteRenderer.color = color;

        yield return new WaitForSeconds(0.05f);

        color.a = 1.0f;
        spriteRenderer.color = color;
    }

}