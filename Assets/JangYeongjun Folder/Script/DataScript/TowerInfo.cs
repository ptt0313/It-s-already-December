using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TowerInfo
{
    protected string name;
    public string description;
    public int attackPower;
    public int attackSpeed;
    public string Name { get { return name; } }
    public string Description { get { return description; } }
    public int AttackPower { get { return attackPower; } set { attackPower = value; } }
    public int AttackSpeed { get { return attackSpeed; } set { attackSpeed = value; } }
    public TowerInfo()
    {
        Init();
    }
    protected abstract void Init();
}
