using UnityEngine;

namespace Unit
{
    [RequireComponent(typeof(Rigidbody))]
    public class Unit : MonoBehaviour, ICar
    {
        [Header("Acceleration")] 
        [SerializeField] private float magnitude;
        [SerializeField] private float maxSpeed;
        [SerializeField] private float minInputSum;

        [Header("Steering")]
        [SerializeField] private float angularSpeed;
        
        [Header("Dependencies")]
        [SerializeField] private new Rigidbody rigidbody;
        
        public float Magnitude => magnitude;
        public float MaxSpeed => maxSpeed;
        public float MinInputSum => minInputSum;
        public float AngularSpeed => angularSpeed;
        public Rigidbody Rigidbody => rigidbody;
        public Transform Transform => transform;
    }
}