using Commons;
using UnityEngine;

namespace Accelerations
{
    public class Acceleration : ISystemPhysical
    {
        private Rigidbody _rigidBody;
        private Vector3 _vector;
        private float _maxSpeed;

        public Acceleration(float magnitude, float maxSpeed, Rigidbody rb)
        {
            _vector = new Vector3(0, 0, magnitude);
            _rigidBody = rb;
            _maxSpeed = maxSpeed;
        }

        public void FixedUpdate(int touchNumbers)
        {
            if (touchNumbers == 2)
                _rigidBody.AddForce(_vector, ForceMode.Acceleration);

            if (_rigidBody.velocity.magnitude > _maxSpeed)
                _rigidBody.velocity = _rigidBody.velocity.normalized * _maxSpeed;
        }
    }
}