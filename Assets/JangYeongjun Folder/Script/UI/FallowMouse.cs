using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowMouse : MonoBehaviour
{
    private RectTransform rectTransform;

    void Start()
    {
        // RectTransform 컴포넌트 가져오기
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        // 현재 마우스 위치 가져오기
        Vector2 targetPosition;

        // 캔버스 좌표계로 변환
        RectTransformUtility.ScreenPointToLocalPointInRectangle
            (
            rectTransform.parent as RectTransform,
            Input.mousePosition,
            null,
            out targetPosition
        );

        // 마우스 위치로 UI 요소 직접 이동
        rectTransform.anchoredPosition = targetPosition;
    }
}
