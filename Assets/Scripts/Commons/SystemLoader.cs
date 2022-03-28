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
            var inputSum = leftInput.Value + rightInput.Value;
            foreach (var car in _cars)
            {
                if(inputSum >= car.AMinInputSum) 
                    _acceleration.FixedUpdate(car, Input.touchCount, inputSum, car.AMinInputSum);
                else if(inputSum <= car.BMaxInputSum)
                    _acceleration.FixedUpdate(car, Input.touchCount, inputSum, car.BMaxInputSum);
                    
                _steering.FixedUpdate(car, leftInput.Value, rightInput.Value);
            }
        }
    }
}