using System.Collections.Generic;
using System.Linq;
using Drivers.Accelerations;
using Drivers.Steerings;
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

        private Acceleration _acceleration;
        private Steering _steering;

        private void Awake()
        {
            _cars = FindObjectsOfType<MonoBehaviour>().OfType<ICar>();

            _acceleration = new Acceleration();
            _steering = new Steering();
        }
           
        
        private void FixedUpdate()
        {
            foreach (var car in _cars)
            {
                _acceleration.FixedUpdate(car, Input.touchCount);
                _steering.FixedUpdate(car, leftInput.Value, rightInput.Value);
            }
        }
    }
}