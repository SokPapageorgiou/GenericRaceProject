using Accelerations;
using UnityEngine;

namespace Unit
{
    [RequireComponent(typeof(Rigidbody))]
    public class Unit : MonoBehaviour, ICar
    {
        [Header("Acceleration")] 
        [SerializeField] private float magnitude;
        [SerializeField] private float maxSpeed;

        private Rigidbody _rigidbody;
        
        public Acceleration Acceleration { get; set; }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            Acceleration = new Acceleration(magnitude, maxSpeed, _rigidbody);
        }
    }
}