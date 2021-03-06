using ScriptableObjects;
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
            var posY = _rectTransform.anchoredPosition.y + eventData.delta.y;
            posY = Mathf.Clamp(posY, range, 0);

            _rectTransform.anchoredPosition = new Vector2(0, posY);
        }

        private void UpdateOutput(float positionY) => valueOutput.Value = NormalizeOutput(positionY);

        private float NormalizeOutput(float positionY) => positionY / range;
    }
}
