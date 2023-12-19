using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTile : MonoBehaviour
{
    private TowerSpawn towerSpawn;
    private Camera cameraMain;
    public int towerNumber = 0;
    private Ray ray;
    private RaycastHit hit;

    private void Awake()
    {
        cameraMain = Camera.main;
        towerSpawn = GetComponent<TowerSpawn>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = cameraMain.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(hit.transform.CompareTag("Tile"))
                {
                    towerSpawn.SpawnTower(towerNumber, hit.transform);
                }
            }
        }
    }
}
