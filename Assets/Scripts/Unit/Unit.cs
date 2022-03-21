using Accelerations;
using Steerings;
using UnityEngine;

namespace Unit
{
    [RequireComponent(typeof(Rigidbody))]
    public class Unit : MonoBehaviour, ICar
    {
        [Header("Acceleration")] 
        [SerializeField] private float magnitude;
        [SerializeField] private float maxSpeed;

        [Header("Steering")]
        [SerializeField] private float angularSpeed;
        
        private Rigidbody _rigidbody;
        
        public Acceleration Acceleration { get; set; }
        public Steering Steering { get; set; }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            Acceleration = new Acceleration(magnitude, maxSpeed, _rigidbody, this.transform);
            Steering = new Steering(angularSpeed, _rigidbody);
        }
    }
}