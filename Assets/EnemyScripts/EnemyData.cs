using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    [SerializeField] private Slider hpbar;

    private float maxHp = 100;
    private float currnetHp = 100;
    void Start()
    {
        hpbar.value = currnetHp / maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currnetHp -= 10;
        }
        HandleHp();
    }

    private void HandleHp()
    {
        hpbar.value = Mathf.Lerp(hpbar.value, currnetHp / maxHp, Time.deltaTime * 10);
    }
}