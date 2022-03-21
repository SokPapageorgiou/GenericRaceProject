using System;
using Accelerations;
using UnityEngine;

namespace Unit
{
    [RequireComponent(typeof(Rigidbody))]
    public class Unit : MonoBehaviour, ICar
    {
        [Header("Acceleration")] 
        [SerializeField] private float magnitude; 
        
        public Acceleration Acceleration { get; set; }
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            Acceleration = new Acceleration(magnitude, _rigidbody);
        } 
           
        
    }
}