using System.Collections.Generic;
using System.Linq;
using ScriptableObjects;
using Unit;
using UnityEngine;

namespace Commons
{
    public class SystemLoader : MonoBehaviour
    {
        [SerializeField] private FloatValue leftInput;
        [SerializeField] private FloatValue rightInput;
        
        private IEnumerable<ICar> _cars;

        private void Awake() 
            => _cars = FindObjectsOfType<MonoBehaviour>().OfType<ICar>();
        
        private void FixedUpdate()
        {
            foreach (var entity in _cars)
            {
                entity.Acceleration.FixedUpdate(Input.touchCount);
                entity.Steering.FixedUpdate(leftInput.Value, rightInput.Value);
            }
        }
    }
}