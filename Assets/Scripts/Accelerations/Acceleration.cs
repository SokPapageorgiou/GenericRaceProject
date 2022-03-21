using Commons;
using UnityEngine;

namespace Accelerations
{
    public class Acceleration : ISystemPhysical
    {
        private Rigidbody _rigidbody;
        private float _magnitude;
        private float _maxSpeed;
        private Transform _transform;

        public Acceleration(float magnitude, float maxSpeed, Rigidbody rb, Transform transform)
        {
            _magnitude = magnitude;
            _rigidbody = rb;
            _maxSpeed = maxSpeed;
            _transform = transform;
        }

        public void FixedUpdate(int touchNumbers)
        {
            AddForce(touchNumbers);
            ConstrainSpeed();
        }

        private void AddForce(int touchNumbers)
        {
            if (touchNumbers == 2)
                _rigidbody.AddForce(_transform.forward * _magnitude, ForceMode.Acceleration);
        }

        private void ConstrainSpeed()
        {
            if (_rigidbody.velocity.magnitude > _maxSpeed)
                _rigidbody.velocity = _rigidbody.velocity.normalized * _maxSpeed;
        }
    }
}