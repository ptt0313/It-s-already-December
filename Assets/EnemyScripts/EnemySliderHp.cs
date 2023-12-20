using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySliderHp : MonoBehaviour
{
    [SerializeField]
    private Vector3 distance = Vector3.down * 20f;
    private Transform targetTransform;
    private RectTransform rectTransform;


    public void SetUp(Transform target)
    {
        targetTransform =target;      //Slider UI가 쫓아다닐 target 설정
        rectTransform = GetComponent<RectTransform>(); 
    }

    private void LateUpdate()
    {
        // 적이 파괴되어 쫓아다닐 대상이 사라지면 slider UI도 삭제
        if(targetTransform ==null)
        {
            Destroy(gameObject);
            return;
        }
        //오브젝트의 위치가 갱신된 이후에 slider UI도 함께 위치를 설정하도록 하기 위해 lastupdate

        //오브젝트 월드 좌표를 기준으로 화면에서의 좌표 값을 구함
        Vector3 screenPosition =Camera.main.WorldToScreenPoint(targetTransform.position);
        rectTransform.position = screenPosition + distance;
        // 화면내에서 좌표+ distance만큼 떨어진 위치를 Slider UI 위치로 설정
    }

}
