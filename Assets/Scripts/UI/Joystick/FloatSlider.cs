using System;
using UnityEngine;

namespace UI.Joystick
{
    public class FloatSlider : MonoBehaviour
    {
        [SerializeField] private bool leftSide;

        private Vector3 _initialPosition;

        private void Awake() => _initialPosition = transform.position;
        
        private void Update()
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                var touch = Input.GetTouch(i);
                
                if (touch.phase == TouchPhase.Began)
                    SetBeginningPosition(touch);
                
                if(touch.phase == TouchPhase.Ended)
                    UpdatePosition(_initialPosition);
            }
        }

        private void SetBeginningPosition(Touch touch)
        {
            var touchPosition = touch.position;
            var splitScreen = Screen.width / 2;

            if (leftSide && touchPosition.x < splitScreen)
                UpdatePosition(touchPosition);
            else if (!leftSide && touchPosition.x > splitScreen)
                UpdatePosition(touchPosition);
        }

        private void UpdatePosition(Vector3 targetPosition)
            => transform.position = new Vector3(targetPosition.x, targetPosition.y, 0);
    }
}
