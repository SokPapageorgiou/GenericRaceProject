using UnityEngine;
using UnityEngine.Serialization;

namespace Unit
{
    [RequireComponent(typeof(Rigidbody))]
    public class Unit : MonoBehaviour, ICar
    {
        [Header("Acceleration")] 
        [SerializeField] private float aMagnitude;
        [SerializeField] private float aMaxSpeed;
        [SerializeField] private float aMinInputSum;
        
        [Header("Break / Rear")] 
        [SerializeField] private float bMagnitude;
        [SerializeField] private float bMaxSpeed;
        [SerializeField] private float bMaxInputSum;

        [Header("Steering")]
        [SerializeField] private float angularSpeed;
        
        [Header("Dependencies")]
        [SerializeField] private new Rigidbody rigidbody;
        
        public float AMagnitude => aMagnitude;
        public float AMaxSpeed => aMaxSpeed;
        public float AMinInputSum => aMinInputSum;
        public float BMagnitude => bMagnitude;
        public float BMaxSpeed => bMaxSpeed;
        public float BMaxInputSum => bMaxInputSum;
        public float AngularSpeed => angularSpeed;
        public Rigidbody Rigidbody => rigidbody;
        public Transform Transform => transform;
    }
}