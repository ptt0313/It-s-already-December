using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType 
{
    Add,
    Overrider,
}

[SerializeField]
public class EnemyStatsHandler : MonoBehaviour
{
    public StatsChangeType ChangeType;
   [Range(1,50)]public float maxHealth;
    [Range(1, 50)] public float currentHealth;
   [Range(1, 10)] public int speed;

    public  EnemyObjectable enemyObjectable;

    public float MaxHealth => maxHealth;
    public float CurrentHealth => currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }
}


