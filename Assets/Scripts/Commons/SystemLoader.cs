using System.Collections.Generic;
using System.Linq;
using Unit;
using UnityEngine;

namespace Commons
{
    public class SystemLoader : MonoBehaviour
    {
        private IEnumerable<ICar> _cars;

        private void Awake() 
            => _cars = FindObjectsOfType<MonoBehaviour>().OfType<ICar>();
        
        private void FixedUpdate()
        {
            foreach (var entity in _cars)
            {
                entity.Acceleration.FixedUpdate(Input.touchCount);
            }
        }
    }
}