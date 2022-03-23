using Commons;
using Unit;
using UnityEngine;

namespace Drivers.Steerings
{
    public class Steering : ISystemPhysical
    {
        public void FixedUpdate(ICar car, float leftInput, float rightInput)
        {
            var deltaRotation = SetDeltaRotation(car, leftInput, rightInput);
            car.Rigidbody.MoveRotation(car.Rigidbody.rotation * deltaRotation); 
        }

        private static Quaternion SetDeltaRotation(ICar car, float leftInput, float rightInput) =>
            Quaternion.Euler((rightInput - leftInput) * Time.fixedDeltaTime * SetEulerVelocityAngle(car.AngularSpeed));
        
        private static Vector3 SetEulerVelocityAngle(float angularSpeed) 
            => new Vector3(0, angularSpeed, 0);
    }
}