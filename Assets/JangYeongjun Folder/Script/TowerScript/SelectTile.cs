using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTile : MonoBehaviour
{
    private TowerSelect towerSelect;
    private Camera cameraMain;

    private Ray ray;
    private RaycastHit hit;
    private void Awake()
    {
        cameraMain = Camera.main;
        towerSelect = GetComponent<TowerSelect>();
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
                    towerSelect.SelectTower(hit.transform);
                }
            }
        }
    }
}
