using UI.ScriptableObjects;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Joystick
{
    public class Movement : MonoBehaviour, IDragHandler, IEndDragHandler
    {
        [Header("SetUp")]
        [SerializeField] private float range;

        [Header("Output")] 
        [SerializeField] private FloatValue valueOutput;
        
        private RectTransform _rectTransform;
        
        private void Awake() => _rectTransform = GetComponent<RectTransform>(); 
        
        public void OnDrag(PointerEventData eventData)
        { 
            UpdatePosition(eventData);
            UpdateOutput(_rectTransform.anchoredPosition.y);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            _rectTransform.anchoredPosition = new Vector2(0, 0);
            UpdateOutput(0);
        } 
       
        private void UpdatePosition(PointerEventData eventData)
        {
            var deltaY = eventData.delta.y;
            var anchoredPositionY = _rectTransform.anchoredPosition.y;

            if (anchoredPositionY <= 0 && anchoredPositionY > range) _rectTransform.anchoredPosition += new Vector2(0, deltaY);
        }

        private void UpdateOutput(float positionY) => valueOutput.Value = NormilizeOutput(positionY); 
        
        private float NormilizeOutput(float positionY) => positionY / range;
    }
}
