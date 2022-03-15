using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Joystick
{
    public class Movement : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        private RectTransform _rectTransform;
        private float _startPositionY;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _startPositionY = _rectTransform.anchoredPosition.y;
        } 
        
        public void OnDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition += new Vector2(0, eventData.delta.y);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition = new Vector2(0, 0);
        }
    }
}
