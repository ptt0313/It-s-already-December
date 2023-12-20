using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab; // 적 프리펩
    [SerializeField]
    private GameObject enemyHpSliderPrefab;// 적 체력을 나타내는 Slider UI프리펩
    [SerializeField]
    private Transform canvasTransform; // UI를 표현하는 Canvas 오브젝트의 Transform

    [SerializeField]
    private float spawnTime;  //적 생성 주기
    [SerializeField]
    private Transform[] wayPoints; //현재 스테이지의 이동 경로

    private void Awake()
    {
        StartCoroutine("SpawnEnemy");
    }

    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject clone = Instantiate(enemyPrefab);  //적 오브젝트 생성
            Enemy enemy = clone.GetComponent<Enemy>();  //방금 생성된 적의 Enemy 컴포넌트

            enemy.Setup(wayPoints);                     //wayPoint 정보를 매개변수로 Setup() 호출

            SpawnEnemyHpSlider(clone);
            yield return new WaitForSeconds(spawnTime); //spawnTime 시간 동안 대기

        }
    }

    private void SpawnEnemyHpSlider(GameObject enemy)
    {  //적 체력을 나타내는 Slider UI 생성
        GameObject sliderClone = Instantiate(enemyHpSliderPrefab);
       //Slider UI 오브젝트를 parent("Canvas" 오브젝트)의 자식으로 설정
        sliderClone.transform.SetParent(canvasTransform);
        //계층 설정으로 바뀐 크기를 다시(1,1,1)으로 설정
        sliderClone.transform.localScale = Vector3.one;

        // Slider UI가 쫓아다닐 대상을 본인으로 설정
        sliderClone.GetComponent<EnemySliderHp>().SetUp(enemy.transform);
        // Slider UI에 자신의 체력 정보를 표시하도록 설정
        sliderClone.GetComponent<EnemyHpViewer>().Setup(enemy.GetComponent<EnemyStatsHandler>());
    }

}
