using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Overrider,
}


public class EnemyStatsHandler 
{
    public StatsChangeType ChangeType;
   [Range(1,50)]public int maxHealth;
   [Range(1, 10)] public int speed;

}
