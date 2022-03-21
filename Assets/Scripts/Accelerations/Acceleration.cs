using Commons;
using UnityEngine;

namespace Accelerations
{
    public class Acceleration : ISystemPhysical
    {
        private Rigidbody _rigidBody;
        private Vector3 _vector;

        public Acceleration(float magnitude, Rigidbody rb)
        {
            _vector = new Vector3(0, 0, magnitude);
            _rigidBody = rb;
        }

        public void FixedUpdate(int touchNumbers)
        {
            if (touchNumbers == 2)
            {
                _rigidBody.AddForce(_vector, ForceMode.Acceleration);
                Debug.Log(_rigidBody.velocity);
            }
        }
    }
}