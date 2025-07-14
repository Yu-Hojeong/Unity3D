using UnityEngine;
using UnityEngine.EventSystems;

public class UIHandler : MonoBehaviour, IPointerDownHandler, IDragHandler
{

    RectTransform parentRect;


    Vector2 basePos;
    Vector2 startPos;
    Vector2 moveOffset;


    void Awake()
    {
        parentRect = transform.parent.GetComponent<RectTransform>();
        // parentRect.SetAsFirstSibling();
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        parentRect.SetAsLastSibling();


        basePos = parentRect.anchoredPosition; //기존 UI 위치
        startPos = eventData.position; // 시작점
    }
    public void OnDrag(PointerEventData eventData)
    {
        moveOffset = eventData.position - startPos;
        parentRect.anchoredPosition = basePos + moveOffset;
    }

    
}
