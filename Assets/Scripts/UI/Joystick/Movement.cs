using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Joystick
{
    public class Movement : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        [SerializeField] private float range;
        
        private RectTransform _rectTransform;
        
        private void Awake() => _rectTransform = GetComponent<RectTransform>(); 
        
        public void OnDrag(PointerEventData eventData) => UpdatePosition(eventData);
        
        public void OnEndDrag(PointerEventData eventData) => _rectTransform.anchoredPosition = new Vector2(0, 0);
       
        private void UpdatePosition(PointerEventData eventData)
        {
            var deltaY = eventData.delta.y;
            var anchoredPositionY = _rectTransform.anchoredPosition.y;

            if (anchoredPositionY <= 0 && anchoredPositionY >= range) _rectTransform.anchoredPosition += new Vector2(0, deltaY);
        }
    }
}
