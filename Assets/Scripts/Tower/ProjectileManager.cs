using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManager : MonoBehaviour
{
    private ProjectileManager _instance;
    public ProjectileManager Instance {  get { return _instance; } }

    [SerializeField] private GameObject _bullet;
    [SerializeField] private int initialPoolSize;
    [SerializeField] private int maxPoolSize;

    private void Awake()
    {
        _instance = this;
    }


}
