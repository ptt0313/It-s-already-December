using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpViewer : MonoBehaviour
{
    private EnemyStatsHandler StatHandler;
    private Slider hpSlider;

    public void Setup(EnemyStatsHandler statsHandler)
    {
        StatHandler = statsHandler;
        hpSlider = GetComponent<Slider>();
    }

    private void Update()
    {
        hpSlider.value =(float)StatHandler.currentHealth/(float)StatHandler.maxHealth;   
    }
}
