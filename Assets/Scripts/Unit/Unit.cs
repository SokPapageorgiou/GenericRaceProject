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
        
        [Header("Dependencies")]
        [SerializeField] private new Rigidbody rigidbody;
        
        public float Magnitude => magnitude;
        public float MaxSpeed => maxSpeed;
        public float AngularSpeed => angularSpeed;
        public Rigidbody Rigidbody => rigidbody;
        public Transform Transform => transform;
    }
}