using Commons;
using UnityEngine;

namespace Steerings
{
    public class Steering : ISystemPhysical
    {
        private Rigidbody _rigidbody;
        private Vector3 _eulerVelocityAngle;

        public Steering(float angularSpeed, Rigidbody rb)
        {
            _rigidbody = rb;
            _eulerVelocityAngle = new Vector3(0, angularSpeed,0);
        }

        public void FixedUpdate(float leftInput, float rightInput)
        {
            var deltaRotation = Quaternion.Euler((rightInput - leftInput) * Time.fixedDeltaTime * _eulerVelocityAngle);
            _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation); 
        }
    }
}